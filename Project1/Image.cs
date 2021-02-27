using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;

namespace ImageProcess
{
    public class Image
    {
        protected enum MODE
        {
            ORIGINAL, POST
        }
        private readonly int offset;
        private Bitmap baseImage;
        private Bitmap postImage;
        private MODE mode = MODE.ORIGINAL;

        public Bitmap BaseImage => baseImage;
        public Bitmap PostImage => postImage;
        public int Offset => offset;

        /// <summary>
        /// yOffset should be the menu bar height
        /// </summary>
        /// <param name="yOffest"></param>
        public Image(int yOffest)
        {
            offset = yOffest;
            baseImage = new Bitmap(600, 400);
        }

        public Image(Image image)
        {
            offset = image.Offset;
            baseImage = new Bitmap(image.BaseImage);
        }

        /// <summary>
        /// reset to base image
        /// </summary>
        public void Reset()
        {
            postImage = new Bitmap(baseImage);
        }

        public void Rebase()
        {
            baseImage = new Bitmap(postImage);
        }

        /// <summary>
        /// clear output image to a specific color
        /// </summary>
        public void Clear(Color color)
        {
            for (int r = 0; r < postImage.Height; r++)
            {
                // Looping over the columns of the array
                for (int c = 0; c < postImage.Width; c++)
                {
                    postImage.SetPixel(c, r, color);
                }
            }
        }

        public Color GetMostCommonColor()
        {
            Dictionary<Color, int> colorCount = new Dictionary<Color, int>();

            for (int y = 0; y < baseImage.Height; y++)
            {
                // Looping over the columns of the array
                for (int x = 0; x < baseImage.Width; x++)
                {
                    var color = baseImage.GetPixel(x, y);

                    if (colorCount.ContainsKey(color))
                    {
                        colorCount[baseImage.GetPixel(x, y)]++;
                    }
                    else
                    {
                        colorCount.Add(color, 1);
                    }
                }
            }

            return colorCount.OrderBy(c => c.Value).Last().Key;
        }

        /// <summary>
        ///  open file if given, otherwise default image from resources
        /// </summary>
        /// <param name="path">path to open</param>
        /// <returns></returns>
        public bool OnOpenDocument(string path = null)
        {
            //open file if given, other wise open default
            try
            {
                if (path == null)
                    baseImage = new Bitmap(Properties.Resources.Stickman);
                else
                    baseImage = new Bitmap(path);

                postImage = new Bitmap(baseImage); //copy bitmap

                mode = MODE.POST;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
                return false;
            }

            return true;
        }


        //save base is the mode is the original (generate), and save the edited one if 
        // if the most is post process (process)
        public bool OnSaveDocument(string path, int index)
        {
            if (mode == MODE.ORIGINAL)
            {
                return OnSave(path, index, baseImage);
            }
            else if (mode == MODE.POST)
            {
                return OnSave(path, index, postImage);
            }
            return false;
        }


        public void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //color the background
            Brush b = new SolidBrush(Color.DarkGray);
            g.FillRectangle(b, e.ClipRectangle);

            if (mode == MODE.ORIGINAL)
            {
                //draw only the original
                g.DrawImage(baseImage, 0, offset);
            }
            else if (mode == MODE.POST)
            {
                //draw BOTH the original and post processed image
                if (baseImage == null)
                    return;

                g.DrawImage(baseImage, 0, offset, baseImage.Width, baseImage.Height);
                g.DrawImage(postImage, baseImage.Width + 2, offset, postImage.Width, postImage.Height);

                //
                // Draw a bar between the two images
                //
                Pen black = new Pen(Color.Black)
                {
                    Width = 3
                };

                g.DrawLine(black, new PointF(baseImage.Width, offset), new PointF(baseImage.Width, baseImage.Height + offset));
            }
        }

        /// <summary>
        /// function to save a image. Supports, jpeg, gif, png, and bmp
        /// </summary>
        /// <param name="path">location to save</param>
        /// <param name="index">index (format type) from file dialog</param>
        /// <param name="image">image to save</param>
        /// <returns></returns>
        public bool OnSave(string path, int index, Bitmap image)
        {
            try
            {
                switch (index)
                {
                    case 1:
                        image.Save(path, ImageFormat.Jpeg);
                        break;
                    case 2:
                        image.Save(path, ImageFormat.Gif);
                        break;
                    case 3:
                        image.Save(path, ImageFormat.Png);
                        break;
                    case 4:
                        image.Save(path, ImageFormat.Bmp);
                        break;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
                return false;
            }

            return true;
        }

        public void Close()
        {
            baseImage = null;
            postImage = null;
        }

        public void ApplyKernel(double[][] kernel)
        {
            Reset();
            Color mostCommonColor = GetMostCommonColor();
            int filterWidth = kernel.Count();
            int filterHeight = kernel.First().Count();

            if (filterWidth % 2 != 1 || filterHeight % 2 != 1)
            {
                throw new ArgumentException("Height and width of filter must be an odd numbers");
            }

            foreach (var filterRow in kernel)
            {
                if (filterRow.Count() != filterHeight)
                {
                    throw new ArgumentException("Width arrays must all be the same length");
                }
            }

            //loop over pixels
            for (int imageRow = 0; imageRow < postImage.Height; imageRow++)
            {
                for (int imageCol = 0; imageCol < postImage.Width; imageCol++)
                {
                    double tallyR = 0;
                    double tallyG = 0;
                    double tallyB = 0;

                    int filterRowLoc = -(filterHeight / 2);

                    foreach (var filterRow in kernel)
                    {
                        int imageRowLocation = imageRow + filterRowLoc;
                        int filterColLoc = -(filterWidth / 2);

                        foreach (var filterValue in filterRow)
                        {
                            int imageColLocation = imageCol + filterColLoc;
                            //assumes anything outside the border of the immage is the most common color in the image
                            Color pixel = mostCommonColor;

                            if (imageColLocation >= 0 && imageColLocation < postImage.Width &&
                                imageRowLocation >= 0 && imageRowLocation < postImage.Height)
                            {
                                pixel = baseImage.GetPixel(imageColLocation, imageRowLocation);
                            }

                            tallyR += pixel.R * filterValue;
                            tallyG += pixel.G * filterValue;
                            tallyB += pixel.B * filterValue;

                            filterColLoc++;
                        }

                        filterRowLoc++;
                    }

                    Color newPixel = Color.FromArgb(tallyR.ToInt().Normalize(), tallyG.ToInt().Normalize(), tallyB.ToInt().Normalize());
                    postImage.SetPixel(imageCol, imageRow, newPixel);
                }
            }
        }

        public delegate Color ColorModification(Color color);
        public delegate Color ColorModificationWithLocation(Color color, int x, int y);
        public void ApplyDelegate(ColorModificationWithLocation cm)
        {
            Reset();

            for (int row = 0; row < baseImage.Height; row++)
            {
                for (int col = 0; col < baseImage.Width; col++)
                {
                    Color newcolor = cm(baseImage.GetPixel(col, row), col, row);
                    postImage.SetPixel(col, row, newcolor);
                }
            }
        }

        public void ApplyDelegate(ColorModification cm)
        {
            Reset();

            for (int row = 0; row < baseImage.Height; row++)
            {
                for (int col = 0; col < baseImage.Width; col++)
                {
                    Color newcolor = cm(baseImage.GetPixel(col, row));
                    postImage.SetPixel(col, row, newcolor);
                }
            }
        }

        public void ApplyMatrix(System.Windows.Media.Matrix matrix)
        {
            Matrix twoDmatrix = new Matrix(
                (float)matrix.M11, (float)matrix.M12,
                (float)matrix.M21, (float)matrix.M22,
                (float)matrix.OffsetX, (float)matrix.OffsetY);

            Graphics g = Graphics.FromImage(postImage);
            g.MultiplyTransform(twoDmatrix);
        }
    }
}
