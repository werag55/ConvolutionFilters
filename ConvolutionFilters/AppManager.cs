using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvolutionFilters
{
    public class AppManager
    {
        int imageWidth, imageHeight;
        ConvolutionFilter currentFilter;
        string imagePath = @"..\..\..\Images\Lenna.png";
        DirectBitmap originalImage;
        public DirectBitmap filteredImage { get; private set; }
        List<ConvolutionFilter> filters;
        public Histogram[] histograms { get; private set; }

        public AppManager(int width, int height)
        {
            imageWidth = width;
            imageHeight = height;
            InitFilters();
            SetImage();
        }

        private void InitFilters()
        {
            float[,] Identity       = { { 0, 0, 0 }, 
                                        { 0, 1, 0 }, 
                                        { 0, 0, 0 } };
            float[,] Blur           = { { 0, 0, 0 },
                                        { 0, 1, 0 },
                                        { 0, 0, 0 } };
            float[,] Sharpen        = { { 0, -1, 0 },
                                        { -1, 5, -1 },
                                        { 0, -1, 0 } };
            float[,] Relief         = { { 0, 0, 0 },
                                      { 0, 1, 0 },
                                      { 0, 0, 0 } };
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

            foreach (var histogram in histograms)
                histogram.CalculateHistogram(filteredImage);
        }

        public void SetImage(string? newImagePath = null)
        {
            if (!string.IsNullOrEmpty(newImagePath)) 
                imagePath = newImagePath;
            originalImage = new DirectBitmap(imageWidth, imageHeight, imagePath);
            filteredImage = currentFilter.ApplyFilter(originalImage);
            InitHistograms();
        }

        public void SetFilter(string filter)
        {
            currentFilter = filters.Where(f => f.filterName == filter).First();
            filteredImage = currentFilter.ApplyFilter(originalImage);
            InitHistograms();
        }
    }
}
