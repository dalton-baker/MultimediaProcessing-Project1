using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

            Matrix t1 = Matrix.Identity;
            Matrix r = Matrix.Identity;
            Matrix t2 = Matrix.Identity;

            t2.Translate(image.BaseImage.Width / 2, image.BaseImage.Height / 2);
            r.Rotate(angle);
            t1.Translate(-image.BaseImage.Width / 2, -image.BaseImage.Height / 2);

            image.ApplyMatrix(t1 * r * t2);
        }
    }
}
