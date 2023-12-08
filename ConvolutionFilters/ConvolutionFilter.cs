using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvolutionFilters
{
    public class ConvolutionFilter
    {
        public string filterName { get; private set; }
        public float[,] filterMatrix;

        public ConvolutionFilter(string filterName, float[,] filterMatrix)
        {
            if (filterMatrix.GetLength(0) % 2 == 0
                || filterMatrix.GetLength(1) % 2 == 0)
                throw new ArgumentException("Inncorect matrix passed to the filter constructor");
            this.filterName = filterName;
            this.filterMatrix = filterMatrix;
        }

        public Color GetFilteredPixel(int x, int y,
            DirectBitmap image, float filterShift = 0, float filterDenom = 1, 
            Histogram[]? histograms = null)
        {
            int imageWidth = image.Width;
            int imageHeight = image.Height;

            int filterWidth = filterMatrix.GetLength(1);
            int filterHeight = filterMatrix.GetLength(0);

            int filterOffsetX = filterWidth / 2;
            int filterOffsetY = filterHeight / 2;

            float red = 0, green = 0, blue = 0;

            for (int filterY = 0; filterY < filterHeight; filterY++)
            {
                for (int filterX = 0; filterX < filterWidth; filterX++)
                {
                    int imageX = x - filterOffsetX + filterX;
                    int imageY = y - filterOffsetY + filterY;

                    if (imageX >= 0 && imageX < imageWidth && imageY >= 0 && imageY < imageHeight)
                    {
                        Color pixel = image.GetPixel(imageX, imageY);
                        float filterMatrixValue = filterMatrix[filterY, filterX];

                        red += pixel.R * filterMatrixValue;
                        green += pixel.G * filterMatrixValue;
                        blue += pixel.B * filterMatrixValue;
                    }
                }
            }

            int newRed = (int)((red / filterDenom) + filterShift);
            int newGreen = (int)((green / filterDenom) + filterShift);
            int newBlue = (int)((blue / filterDenom) + filterShift);

            newRed = Math.Min(255, Math.Max(0, newRed));
            newGreen = Math.Min(255, Math.Max(0, newGreen));
            newBlue = Math.Min(255, Math.Max(0, newBlue));

            if (histograms != null)
            {
                histograms[0].Add(newRed);
                histograms[1].Add(newGreen);
                histograms[2].Add(newBlue);
            }

            return Color.FromArgb(newRed, newGreen, newBlue);
        }

        public DirectBitmap ApplyFilter(DirectBitmap image, float filterShift = 0, float filterDenom = 1, 
            Histogram[]? histograms = null)
        {
            DirectBitmap filteredImage = new DirectBitmap(image.Width, image.Height);

            int imageWidth = image.Width;
            int imageHeight = image.Height;

            for (int y = 0; y < imageHeight; y++)
                for (int x = 0; x < imageWidth; x++)
                    filteredImage.SetPixel(x, y, GetFilteredPixel(x, y, image, filterShift, filterDenom, histograms));

            return filteredImage;
        }

        private bool IsInsideCircle(int x, int y, int centerX, int centerY, int radius)
        {
            int distanceSquared = (x - centerX) * (x - centerX) + (y - centerY) * (y - centerY);
            return distanceSquared <= radius * radius;
        }

        public DirectBitmap ApplyCircularFilter(DirectBitmap image, int centerX, int centerY, int radius, 
            float filterShift = 0, float filterDenom = 1, Histogram[]? histograms = null)
        {
            DirectBitmap filteredImage = new DirectBitmap(image.Width, image.Height);

            int imageWidth = image.Width;
            int imageHeight = image.Height;

            for (int y = 0; y < imageHeight; y++)
            {
                for (int x = 0; x < imageWidth; x++)
                {
                    if (IsInsideCircle(x, y, centerX, centerY, radius))
                        filteredImage.SetPixel(x, y, GetFilteredPixel(x, y, image, filterShift, filterDenom, histograms));
                    else
                    {
                        Color color = image.GetPixel(x, y);
                        filteredImage.SetPixel(x, y, color);
                        if (histograms != null)
                        {
                            histograms[0].Add(color.R);
                            histograms[1].Add(color.G);
                            histograms[2].Add(color.B);
                        }
                    }
                }
            }

            return filteredImage;
        }
    }
}
