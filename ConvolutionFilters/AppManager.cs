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

        private void ApplyFilter()
        {
            ClearHistograms();
            filteredImage = currentFilter.ApplyFilter(originalImage,
                filterShift, filterDenom, histograms);
        }

        public void SetImage(string? newImagePath = null)
        {
            if (!string.IsNullOrEmpty(newImagePath)) 
                imagePath = newImagePath;
            originalImage = new DirectBitmap(imageWidth, imageHeight, imagePath);
            ApplyFilter();
        }

        public void SetFilter(string filter)
        {
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
            }
            else
                filterDenom = 1;
        }
    }
}
