namespace ConvolutionFilters
{
    public partial class ConvolutionFilters : Form
    {
        AppManager appManager;
        public ConvolutionFilters()
        {
            InitializeComponent();
            appManager = new AppManager(pictureBox.Width, pictureBox.Height);
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(appManager.filteredImage.Bitmap, Point.Empty);
        }

        private void redHistPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(appManager.histograms[0].DrawHistogram((PictureBox)sender),
                Point.Empty);
        }

        private void greenHistPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(appManager.histograms[1].DrawHistogram((PictureBox)sender),
                Point.Empty);
        }

        private void blueHistPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(appManager.histograms[2].DrawHistogram((PictureBox)sender),
                Point.Empty);
        }

        private void filterChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                appManager.SetFilter(((RadioButton)sender).Text);
            Refresh();
        }
    }
}