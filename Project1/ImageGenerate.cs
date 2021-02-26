using System;
using System.Drawing;

namespace ImageProcess
{
    public class ImageGenerate : ImageEditor
    {

        public override void SetMode(MODE m) {
            switch (m)
            {
                case MODE.None:
                    mouseMode = MODE.None;
                    break;
                case MODE.Threshold:
                    break;
                case MODE.Draw:
                    mouseMode = MODE.Draw;
                    break;
                case MODE.Move:
                    break;
                case MODE.Warp:
                    break;
                case MODE.WarpNearest:
                    break;
            }
        }

        //
        //basic generation functions-------------------------------------------
        //


        /// <summary>
        /// This class function fills the base image with white.
        /// </summary>
        /// <param name="image">image to edit</param>
        public static void FillWhite(Image image)
        {
            for (int r = 0; r < image.BaseImage.Height; r++)
            {
                // Looping over the columns of the array
                for (int c = 0; c < image.BaseImage.Width ; c++)
                {
                    image.BaseImage.SetPixel(c, r, Color.White);
                }
            }

        }

        /// <summary>
        /// This class function fills the base image with black.
        /// </summary>
        /// <param name="image">image to edit</param>
        public static void FillBlack(Image image)
        {
            for (int r = 0; r < image.BaseImage.Height; r++)
            {
                // Looping over the columns of the array
                for (int c = 0; c < image.BaseImage.Width; c++)
                {
                    image.BaseImage.SetPixel(c, r, Color.Black);
                }
            }

        }

        public static void FillGreen(Image image)
        {
            for (int r = 0; r < image.BaseImage.Height; r++)
            {
                // Looping over the columns of the image
                for (int c = 0; c < image.BaseImage.Width; c++)
                {
                    image.BaseImage.SetPixel(c, r, Color.Green);
                }
            }
        }


        public static void FillLavender(Image image)
        {
            for (int r = 0; r < image.BaseImage.Height; r++)
            {
                // Looping over the columns of the image
                for (int c = 0; c < image.BaseImage.Width; c++)
                {
                    image.BaseImage.SetPixel(c, r, Color.Lavender);
                }
            }
        }

        public static void HorizontalGradient(Image image)
        {
            for (int c = 0; c < image.BaseImage.Width; c++)
            {
                for (int r = 0; r < image.BaseImage.Height; r++)
                {
                    int pixelVal = (int)(c / (float)image.BaseImage.Width * 255);
                    image.BaseImage.SetPixel(c, r, Color.FromArgb(pixelVal, pixelVal, pixelVal));
                }
            }
        }

        public static void VerticalBlueGradient(Image image)
        {
            for (int c = 0; c < image.BaseImage.Width; c++)
            {
                for (int r = 0; r < image.BaseImage.Height; r++)
                {
                    int pixelVal = 255 - (int)(r / (float)image.BaseImage.Height * 255);
                    image.BaseImage.SetPixel(c, r, Color.FromArgb(0, 0, pixelVal));
                }
            }
        }

        public static void DiagonalGradient(Image image)
        {
            for (int c = 0; c < image.BaseImage.Width; c++)
            {
                for (int r = 0; r < image.BaseImage.Height; r++)
                {
                    float gradPercentage = (image.BaseImage.Height - r + c) / (image.BaseImage.Width + (float)image.BaseImage.Height);

                    int redVal = (int)(255 * (1 - gradPercentage));
                    int greenVal = (int)(255 * gradPercentage);

                    image.BaseImage.SetPixel(c, r, Color.FromArgb(redVal, greenVal, 0));
                }
            }
        }


        public static void HorizontalLine(Image image)
        {
            int r = 100;

            for (int c = 0; c < image.BaseImage.Width; c++)
            {
                image.BaseImage.SetPixel(c, r, Color.Yellow);
            }
        }

        public static void VerticalLine(Image image)
        {
            int c = 100;

            for (int r = 0; r < image.BaseImage.Height; r++)
            {
                image.BaseImage.SetPixel(c, r, Color.Yellow);
                image.BaseImage.SetPixel(c+1, r, Color.Yellow);
            }
        }
        
        public static void DiagonalLine(Image image)
        {
            int r = 100;

            for(int c = 100; c <= 400; c++)
            {
                if(c % 3 == 0)
                {
                    r++;
                }
                image.BaseImage.SetPixel(c, r, Color.Yellow);
            }
        }

        //
        // Mouse functions----------------------------------------------------
        //

        /// <summary>
        /// Draw a red dot at the given point onthe base image
        /// </summary>
        /// <param name="image"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public override void MousePress(Image image, int x, int y)
        {
            // We count the mouse clicks
            switch (mouseMode)
            {
                case MODE.Draw:
                    if(x< image.BaseImage.Width && y < image.BaseImage.Height)
                        image.BaseImage.SetPixel(x, y- image.Offset, Color.Red);
                    mouseMode = MODE.Move;
                    break;

            }
        }

        public override void MouseRelease()
        {
            if(mouseMode == MODE.Move)
                mouseMode = MODE.Draw;
        }

        /// <summary>
        /// Draw a red dot at the given point onthe base image
        /// </summary>
        /// <param name="image"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public override void MouseMove(Image image, int x, int y)
        {

            switch (mouseMode)
            {
                case MODE.Move:
                    if (x < image.BaseImage.Width && y < image.BaseImage.Height)
                        image.BaseImage.SetPixel(x, y- image.Offset, Color.Red);
                    break;
            }

        }
    }
}
