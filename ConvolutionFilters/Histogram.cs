using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvolutionFilters
{
    public class Histogram
    {
        public string histColor { get; private set; }
        public int[] colorDistribution = new int[256];
        public Histogram(string color) 
        { histColor = color; }

        public void Clear()
        { colorDistribution = new int[256]; }

        public void Add(int intensity)
        { colorDistribution[intensity]++; }

        public void CalculateHistogram(DirectBitmap image)
        {
            int height = image.Height, width = image.Width;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    switch (histColor)
                    {
                        case "Red":
                            Add(pixelColor.R); break;
                        case "Green":
                            Add(pixelColor.G); break;
                        case "Blue":
                            Add(pixelColor.B); break;
                    }
                }
            }
        }

        public void DrawGrid(Graphics g, int pictureBoxWidth, int pictureBoxHeight)
        {
            Pen gridPen = new Pen(Color.LightGray); 
            int numOfVerticalLines = 10; 
            int numOfHorizontalLines = 10; 

            for (int i = 0; i <= numOfVerticalLines; i++)
            {
                int x = (i * pictureBoxWidth) / numOfVerticalLines;
                g.DrawLine(gridPen, x, 0, x, pictureBoxHeight);
            }

            for (int i = 0; i <= numOfHorizontalLines; i++)
            {
                int y = (i * pictureBoxHeight) / numOfHorizontalLines;
                g.DrawLine(gridPen, 0, y, pictureBoxWidth, y);
            }
        }
        public Bitmap DrawHistogram(PictureBox pictureBox)
        {
            Bitmap histogramBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);

            using (Graphics g = Graphics.FromImage(histogramBitmap))
            {
                g.Clear(Color.White);

                DrawGrid(g, pictureBox.Width, pictureBox.Height);

                Pen histPen = new Pen(Color.Black);
                Brush histBrush;
                switch(histColor)
                {
                    case "Red":
                        histPen.Color = Color.Red;
                        histBrush = new SolidBrush(Color.Red);
                        break;
                    case "Green":
                        histPen.Color = Color.Green;
                        histBrush = new SolidBrush(Color.Green);
                        break;
                    case "Blue":
                        histPen.Color = Color.Blue;
                        histBrush = new SolidBrush(Color.Blue);
                        break;
                    default: 
                        histBrush = new SolidBrush(Color.Black);
                        break;
                }

                int maxValue = 0;
                foreach (int value in colorDistribution)
                    maxValue = Math.Max(maxValue, value);

                float barWidth = (float)pictureBox.Width / colorDistribution.Length;

                for (int i = 0; i < colorDistribution.Length; i++)
                {
                    float barHeight = ((float)colorDistribution[i] / maxValue) * pictureBox.Height;

                    RectangleF barRect = new RectangleF(i * barWidth, pictureBox.Height - barHeight, barWidth, barHeight);
                    g.DrawRectangle(histPen, barRect);
                    g.FillRectangle(histBrush, barRect);
                }
            }

            return histogramBitmap;
        }

    }
}
