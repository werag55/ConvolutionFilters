namespace ConvolutionFilters
{
    public partial class ConvolutionFilters : Form
    {
        AppManager appManager;
        public ConvolutionFilters()
        {
            InitializeComponent();
            appManager = new AppManager(pictureBox.Width, pictureBox.Height,
                (float)shiftNumericUpDown.Value, (float)denomNumericUpDown.Value);
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
            {
                appManager.SetFilter(((RadioButton)sender).Text);
                Refresh();
            }
        }

        private void customFilterChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                customButton.Enabled = true;
                filterMatrixPanel.Enabled = true;
            }
            else
            {
                customButton.Enabled = false;
                filterMatrixPanel.Enabled = false;
            }
        }

        private void customButton_Click(object sender, EventArgs e)
        {
            int rows = 3, columns = 3;
            float[,] matrix = new float[rows, columns];

            int index = 0;
            foreach (Control control in filterMatrixPanel.Controls)
            {
                if (control is NumericUpDown numericUpDown)
                {
                    matrix[index / columns, index % columns] = (float)numericUpDown.Value;
                    index++;
                }
            }

            appManager.filters.Last().filterMatrix = matrix;
            appManager.SetFilter(appManager.filters.Last().filterName);

            Refresh();
        }

        private void shiftNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            appManager.SetFilterShift((float)((NumericUpDown)sender).Value);
            Refresh();
        }

        private void denomNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            appManager.SetFilterDenom((float)((NumericUpDown)sender).Value);
            Refresh();
        }

        private void autoDenomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            appManager.SetFilterCalculation(((CheckBox)sender).Checked,
                (float)(denomNumericUpDown.Value));
            if (((CheckBox)sender).Checked)
                denomNumericUpDown.Enabled = false;
            else
                denomNumericUpDown.Enabled = true;
            Refresh();
        }

        private void chooseImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dir = Application.StartupPath;
            for (int i = 0; i < 2; i++)
                dir = Directory.GetParent(dir).Parent.FullName;
            string imagesDirectory = Path.Combine(dir, "Images");


            OpenFileDialog openFileDialog = new();
            openFileDialog.InitialDirectory = imagesDirectory;
            openFileDialog.Filter = "Images (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                appManager.SetImage(openFileDialog.FileName);
                Refresh();
            }
        }
    }
}