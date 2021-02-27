using System;
using System.Drawing;
using System.Windows.Media;

namespace ImageProcess
{
    public partial class ImageProcess : ImageEditor
    {
        public static void OnPointillize(Image image)
        {
            image.Reset();

            int elipseSize = 14;
            int numberOfPoints = image.BaseImage.Width * image.BaseImage.Height / (elipseSize / 2);
            Random rand = new Random();
            image.Clear(Color.White);
            Graphics g = Graphics.FromImage(image.PostImage);

            for (int i = 0; i < numberOfPoints; i++)
            {
                int randX = rand.Next(0, image.BaseImage.Width);
                int randY = rand.Next(0, image.BaseImage.Height);

                SolidBrush brush = new SolidBrush(image.BaseImage.GetPixel(randX, randY));
                g.FillEllipse(brush, randX - elipseSize / 2, randY - elipseSize / 2, elipseSize, elipseSize);
            }
        }

        public static void OnSharpen3X3(Image image)
        {
            image.Reset();

            double[][] kernel = new double[][]
            {
                new double[] { -1, -1, -1},
                new double[] { -1, 9, -1},
                new double[] { -1, -1, -1},
            };

            image.ApplyKernel(kernel);
        }

        public static void OnPrewitt5X5(Image image)
        {
            image.Reset();

            Image bAndW = new Image(image);
            OnFilterMonochrome(bAndW);
            bAndW.Rebase();

            Image vertical = new Image(bAndW);
            Image horizontal = new Image(bAndW);

            double[][] verticalKernel = new double[][]
            {
                new double[] { 2, 1, 0, -1, -2},
                new double[] { 2, 1, 0, -1, -2},
                new double[] { 2, 1, 0, -1, -2},
                new double[] { 2, 1, 0, -1, -2},
                new double[] { 2, 1, 0, -1, -2},
            };

            double[][] horizontalKernel = new double[][]
            {
                new double[] { 2, 2, 2, 2, 2},
                new double[] { 1, 1, 1, 1, 1},
                new double[] { 0, 0, 0, 0, 0},
                new double[] { -1, -1, -1, -1, -1},
                new double[] { -2, -2, -2, -2, -2},
            };

            vertical.ApplyKernel(verticalKernel);
            horizontal.ApplyKernel(horizontalKernel);

            image.ApplyDelegate((c, x, y) =>
            {
                Color vertColor = vertical.PostImage.GetPixel(x, y);
                Color horiColor = horizontal.PostImage.GetPixel(x, y);

                int red = Math.Abs(vertColor.R) + Math.Abs(horiColor.R);
                int blue = Math.Abs(vertColor.B) + Math.Abs(horiColor.B);
                int green = Math.Abs(vertColor.G) + Math.Abs(horiColor.G);

                return Color.FromArgb(red.Normalize(), blue.Normalize(), green.Normalize());
            });
        }

        public static void OnSorbel5X5(Image image)
        {
            image.Reset();

            Image bAndW = new Image(image);
            OnFilterMonochrome(bAndW);
            bAndW.Rebase();

            Image vertical = new Image(bAndW);
            Image horizontal = new Image(bAndW);

            double[][] verticalKernel = new double[][]
            {
                new double[] { 2, 1, 0, -1, -2},
                new double[] { 2, 1, 0, -1, -2},
                new double[] { 4, 2, 0, -2, -4},
                new double[] { 2, 1, 0, -1, -2},
                new double[] { 2, 1, 0, -1, -2},
            };

            double[][] horizontalKernel = new double[][]
            {
                new double[] { 2, 2, 4, 2, 2},
                new double[] { 1, 1, 2, 1, 1},
                new double[] { 0, 0, 0, 0, 0},
                new double[] { -1, -1, -2, -1, -1},
                new double[] { -2, -2, -4, -2, -2},
            };

            vertical.ApplyKernel(verticalKernel);
            horizontal.ApplyKernel(horizontalKernel);

            image.ApplyDelegate((c, x, y) =>
            {
                Color vertColor = vertical.PostImage.GetPixel(x, y);
                Color horiColor = horizontal.PostImage.GetPixel(x, y);

                int red = Math.Abs(vertColor.R) + Math.Abs(horiColor.R);
                int blue = Math.Abs(vertColor.B) + Math.Abs(horiColor.B);
                int green = Math.Abs(vertColor.G) + Math.Abs(horiColor.G);

                return Color.FromArgb(red.Normalize(), blue.Normalize(), green.Normalize());
            });
        }

        public static void OnRotateCenter(Image image, double angle)
        {
            image.Reset();

            Matrix rotate = Matrix.Identity;
            rotate.RotateAt(angle, image.BaseImage.Width / 2, image.BaseImage.Height / 2);

            image.ApplyMatrix(rotate);
        }

        public static void OnFlipAndTranslate(Image image, int xTrans, int yTrans)
        {
            image.Reset();

            Image tempImage = new Image(image);
            tempImage.PostImage.RotateFlip(RotateFlipType.RotateNoneFlipX);

            Matrix t1 = Matrix.Identity;
            t1.Translate(xTrans, yTrans);
            image.ApplyMatrix(t1, tempImage);
        }

        public static void OnGreenScreen(Image backImg, Image frontImg, double a1, double a2, int xOffset = 0, int yOffset = 0)
        {
            backImg.Reset();
            frontImg.Reset();

            backImg.ApplyDelegate((c, x, y) =>
            {                
                if (x < frontImg.PostImage.Width + xOffset && x >= xOffset &&
                    y < frontImg.PostImage.Height + yOffset && y >= yOffset)
                {
                    Color frontImgColor = frontImg.PostImage.GetPixel(x - xOffset, y - yOffset);

                    double alpha = 1 - (a1 * ((frontImgColor.B/255.0) - (a2 * (frontImgColor.G / 255.0))));

                    int red = (int)((alpha * frontImgColor.R) + ((1 - alpha) * c.R));
                    int green = (int)((alpha * frontImgColor.G) + ((1 - alpha) * c.G));
                    int blue = (int)((alpha * frontImgColor.B) + ((1 - alpha) * c.B));

                    return Color.FromArgb(red.Normalize(), green.Normalize(), blue.Normalize());
                }

                return c;
            });

        }

        public static void OnSubSectionWarp(Image image)
        {
            image.Reset();

            Random random = new Random(Guid.NewGuid().GetHashCode());

            int xOffset = random.Next(0, image.BaseImage.Width / 2);
            int yOffset = random.Next(0, image.BaseImage.Height / 2);

            int subWidth = random.Next(image.BaseImage.Width / 4, image.BaseImage.Width / 2);
            int subHeight = random.Next(image.BaseImage.Height / 4, image.BaseImage.Height / 2);

            Image subImage = new Image(0);
            subImage.OnOpenImage(new Bitmap(subWidth, subHeight));
            subImage.ApplyDelegate((c, x, y) =>
            {
                return image.BaseImage.GetPixel(x + xOffset, y + yOffset);
            });
            subImage.Rebase();

            OnRotateCenter(subImage, random.Next(0, 1) == 0 ? random.Next(5, 180) : random.Next(-180, -5));

            image.ApplyDelegate((c, x, y) =>
            {
                if (x < subWidth + xOffset && x >= xOffset &&
                    y < subHeight + yOffset && y >= yOffset)
                {
                    return subImage.PostImage.GetPixel(x - xOffset, y - yOffset);
                }

                return c;
            });
        }
    }
}
