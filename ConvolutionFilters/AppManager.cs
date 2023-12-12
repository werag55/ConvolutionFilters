using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace ConvolutionFilters
{
    public enum Area
    {
        Whole, 
        Circular
    }
    public class AppManager
    {
        int imageWidth, imageHeight;
        public int circleX { get; private set; } = -1;
        public int circleY { get; private set; } = -1;
        public int radius { get; private set; } = 1;
        public Area area { get; private set; } = Area.Whole;
        ConvolutionFilter currentFilter;
        float filterShift;
        float filterDenom;
        bool isDenomAuto = true;
        string imagePath = @"..\..\..\Images\Lenna.png";
        DirectBitmap originalImage;
        public DirectBitmap filteredImage { get; private set; }
        public List<ConvolutionFilter> filters;
        public Histogram[] histograms { get; private set; }

        public AppManager(int width, int height, float shift, float denom)
        {
            imageWidth = width;
            imageHeight = height;
            filterShift = shift;
            filterDenom = denom;
            InitHistograms();
            InitFilters();
            SetImage();
        }

        private void InitFilters()
        {
            // NOTE: Custom filter need to be the last one
            float[,] Identity       = { { 0, 0, 0 }, 
                                        { 0, 1, 0 }, 
                                        { 0, 0, 0 } };
            //float[,] Blur           = { { 1f/16, 1f/8, 1f/16 },
            //                            { 1f/8, 1f/4, 1f/8 },
            //                            { 1f/16, 1f/8, 1f/16 } };
            float[,] Blur           = { { 1f/9, 1f/9, 1f/9 },
                                        { 1f/9, 1f/9, 1f/9 },
                                        { 1f/9, 1f/9, 1f/9 } };
            float[,] Sharpen        = { { 0, -1, 0 },
                                        { -1, 5, -1 },
                                        { 0, -1, 0 } };
            float[,] Relief         = { { -1, 0, 1 },
                                        { -1, 1, 1 },
                                        { -1, 0, 1 } };
            float[,] EdgesDetection = { { -1, -1, -1 },
                                        { -1, 8, -1 },
                                        { -1, -1, -1 } };
            float[,] Custom         = { { 0, 0, 0 },
                                        { 0, 0, 0 },
                                        { 0, 0, 0 } };
            filters = new List<ConvolutionFilter> { 
                new ConvolutionFilter("Identity", Identity),
                new ConvolutionFilter("Blur", Blur),
                new ConvolutionFilter("Sharpen", Sharpen),
                new ConvolutionFilter("Relief", Relief),
                new ConvolutionFilter("Edges detection", EdgesDetection),
                new ConvolutionFilter("Custom", Custom) };

            currentFilter = filters[0];
        }

        private void InitHistograms()
        {
            histograms = new Histogram[3];
            histograms[0] = new Histogram("Red");
            histograms[1] = new Histogram("Green");
            histograms[2] = new Histogram("Blue");
        }

        private void ClearHistograms()
        {
            foreach (var histogram in histograms)
                histogram.Clear();
        }

        private void CalculateHistograms()
        {
            foreach (var histogram in histograms)
                histogram.CalculateHistogram(filteredImage);
        }

        private void ApplyFilter()
        {
            ClearHistograms();

            switch (area)
            {
                case Area.Whole:
                    filteredImage = currentFilter.ApplyFilter(originalImage,
                        filterShift, filterDenom, histograms);
                    break;
                case Area.Circular:
                    if (circleX != -1 && circleY != -1)
                        currentFilter.ApplyCircularFilter(originalImage, filteredImage, circleX, circleY, radius,
                            filterShift, filterDenom, histograms);
                    else
                    {
                        //filteredImage = originalImage; // if brush == window
                        CalculateHistograms();
                    }
                    break;
            }
        }

        public void SetImage(string? newImagePath = null)
        {
            if (!string.IsNullOrEmpty(newImagePath)) 
                imagePath = newImagePath;
            originalImage = new DirectBitmap(imageWidth, imageHeight, imagePath);
            ApplyFilter();
        }

        public void SetImageGenerate1()
        {
            originalImage = new DirectBitmap(imageWidth, imageHeight);

            originalImage.DrawRectangle(0, 0, imageWidth / 4, imageHeight / 2, Color.Black);
            originalImage.DrawRectangle(imageWidth / 4, 0, imageWidth / 4, imageHeight / 2, Color.Red);
            originalImage.DrawRectangle(imageWidth / 2, 0, imageWidth / 4, imageHeight / 2, Color.Green);
            originalImage.DrawRectangle(3 * imageWidth / 4, 0, imageWidth / 4, imageHeight / 2, Color.Blue);

            originalImage.DrawRectangle(0, imageHeight / 2, imageWidth / 4, imageHeight / 2, Color.White);
            originalImage.DrawRectangle(imageWidth / 4, imageHeight / 2, imageWidth / 4, imageHeight / 2, Color.Cyan);
            originalImage.DrawRectangle(imageWidth / 2, imageHeight / 2, imageWidth / 4, imageHeight / 2, Color.Magenta);
            originalImage.DrawRectangle(3 * imageWidth / 4, imageHeight / 2, imageWidth / 4, imageHeight / 2, Color.Yellow);

            ApplyFilter();
        }

        public void SetImageGenerate2()
        {
            originalImage = new DirectBitmap(imageWidth, imageHeight);

            double v = 1;
            for (int y = 0; y < imageHeight; y++)
            {
                for (int x = 0; x < imageWidth; x++)
                {
                    Color color = HSVToRGB((double)x/imageWidth * 360, 1 - (double)y / imageHeight, v);
                    originalImage.SetPixel(x, y, color);
                }
            }

            ApplyFilter();
        }

        public void UpdateImage()
        {
            originalImage = filteredImage.Clone();
            //ApplyFilter();
        }

        public void SetFilter(string filter)
        {
            filter = Regex.Replace(filter, "[&]", "");
            currentFilter = filters.Where(f => f.filterName == filter).First();

            if (isDenomAuto)
                CalculateDenom();

            ApplyFilter();
        }

        public void SetFilterShift(float shift)
        {
            filterShift = shift;
            ApplyFilter();
        }

        public void SetFilterDenom(float denom)
        {
            filterDenom = denom;
            ApplyFilter();
        }

        public void SetFilterCalculation(bool isAutoCalculated, float denom)
        {
            isDenomAuto = isAutoCalculated;

            if (isDenomAuto)
                CalculateDenom();
            else
                filterDenom = denom;

            ApplyFilter();
        }

        private void CalculateDenom()
        {
            if (currentFilter.filterName.Equals("Custom"))
            {
                filterDenom = 0;
                foreach (var cell in currentFilter.filterMatrix)
                    filterDenom += cell;
                if (filterDenom == 0)
                    filterDenom = 1;
            }
            else
                filterDenom = 1;
        }

        public void SetFilterArea(Area a)
        {
            area = a;
            ApplyFilter();
        }

        public void SetCircleCenter(int x, int y)
        {
            circleX = x;
            circleY = y;

            ApplyFilter();
        }

        public void SetCircleRadius(int r)
        {
            radius = r;
            ApplyFilter();
        }

        // https://www.programmingalgorithms.com/algorithm/hsv-to-rgb/
        private Color HSVToRGB(double H, double S, double V)
        {
            double r = 0, g = 0, b = 0;

            if (S == 0)
            {
                r = V;
                g = V;
                b = V;
            }
            else
            {
                int i;
                double f, p, q, t;

                if (H == 360)
                    H = 0;
                else
                    H = H / 60;

                i = (int)Math.Truncate(H);
                f = H - i;

                p = V * (1.0 - S);
                q = V * (1.0 - (S * f));
                t = V * (1.0 - (S * (1.0 - f)));

                switch (i)
                {
                    case 0:
                        r = V;
                        g = t;
                        b = p;
                        break;

                    case 1:
                        r = q;
                        g = V;
                        b = p;
                        break;

                    case 2:
                        r = p;
                        g = V;
                        b = t;
                        break;

                    case 3:
                        r = p;
                        g = q;
                        b = V;
                        break;

                    case 4:
                        r = t;
                        g = p;
                        b = V;
                        break;

                    default:
                        r = V;
                        g = p;
                        b = q;
                        break;
                }

            }

            return Color.FromArgb((int)(r * 255), (int)(g * 255), (int)(b * 255));
        }
    }
}
