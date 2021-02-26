using System;
using System.Collections.Generic;
using System.Drawing;

namespace ImageProcess
{
    public partial class ImageProcess : ImageEditor
    {
        public static void OnPointillize(Image image)
        {
            // reset the filtered image and make the same size as the input image
            image.Reset();

            int elipseSize = 10;
            int numberOfPoints = image.BaseImage.Width * image.BaseImage.Height / 5;
            Random rand = new Random();
            image.Clear(Color.White);
            Graphics g = Graphics.FromImage(image.PostImage);

            for (int i = 0; i < numberOfPoints; i++)
            {
                int randX = rand.Next(0, image.BaseImage.Width);
                int randY = rand.Next(0, image.BaseImage.Height);

                SolidBrush brush = new SolidBrush(image.BaseImage.GetPixel(randX, randY));
                g.FillEllipse(brush, randX - elipseSize/2, randY - elipseSize / 2, elipseSize, elipseSize);
            }
        }
    }
}
