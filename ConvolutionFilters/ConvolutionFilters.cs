using System.Windows.Forms;

namespace ConvolutionFilters
{
    public partial class ConvolutionFilters : Form
    {
        AppManager appManager;
        string prevValue = "";
        ErrorProvider errorProvider = new();
        bool skipMouseLeave = false;

        public ConvolutionFilters()
        {
            InitializeComponent();
            appManager = new AppManager(pictureBox.Width, pictureBox.Height,
                (float)shiftNumericUpDown.Value, (float)denomNumericUpDown.Value);
        }

        #region PictureBoxes PaintEvents
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

        #endregion

        #region FilterChanges
        private void filterChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                appManager.SetFilter(((RadioButton)sender).Text);
                Refresh();
            }
        }

        #region CustomFilter
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

        #endregion
        private void shiftNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            appManager.SetFilterShift((float)((NumericUpDown)sender).Value);
            Refresh();
        }

        #region Denom
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
        #endregion
        #endregion

        #region Menu
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

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JPEG files|*.jpg;*.jpeg|All files|*.*";
                saveFileDialog.Title = "Save Image";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap imageToSave = new Bitmap(pictureBox.Width, pictureBox.Height);
                    using (Graphics g = Graphics.FromImage(imageToSave))
                    {
                        g.DrawImage(appManager.filteredImage.Bitmap, Point.Empty);
                    }
                    imageToSave.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageToSave.Dispose();
                }
            }
        }

        #endregion

        #region CircularBrush

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (appManager.area == Area.Circular)
            {
                Point p = ((PictureBox)sender).PointToClient(MousePosition);
                appManager.SetCircleCenter(p.X, p.Y);
                Refresh();
            }
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (appManager.area == Area.Circular && !skipMouseLeave)
            {
                appManager.SetCircleCenter(-1, -1);
                Refresh();
            }

            skipMouseLeave = false;
        }

        private void brushRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                brushRadiusTrackBar.Enabled = true;
                brushRadiusTextBox.Enabled = true;

                appManager.SetFilterArea(Area.Circular);
            }
            else
            {
                brushRadiusTrackBar.Enabled = false;
                brushRadiusTextBox.Enabled = false;

                appManager.SetFilterArea(Area.Whole);
            }

            Refresh();
        }

        #region TextBox

        private void TextBox_Enter(object sender, EventArgs e)
        {
            prevValue = ((TextBox)sender).Text;
            ((TextBox)sender).Clear();
        }

        private void integerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                (sender as TextBox).Parent.Focus();

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void validatingTextBox(object sender, System.ComponentModel.CancelEventArgs e)
        {
            float min = brushRadiusTrackBar.Minimum, max = brushRadiusTrackBar.Maximum;
            if (((TextBox)sender).Text == " ")
                return;

            if (string.IsNullOrEmpty(((TextBox)sender).Text))
                ((TextBox)sender).Text = prevValue;

            string errorMsg = $"Enter a value between {min} and {max}";
            try
            {
                float result = float.Parse(((TextBox)sender).Text.ToString());
                if (result > max || result < min)
                {
                    e.Cancel = true;
                    ((TextBox)sender).Select(0, ((TextBox)sender).Text.Length);
                    this.errorProvider.SetError((TextBox)sender, errorMsg);
                }
                else
                    this.errorProvider.Clear();
            }
            catch
            {
                e.Cancel = true;
                this.errorProvider.SetError((TextBox)sender, errorMsg);
            }
        }

        private void brushRadiusTextBox_Validated(object sender, EventArgs e)
        {
            int result = int.Parse(brushRadiusTextBox.Text.ToString());
            brushRadiusTrackBar.Value = result;
            appManager.SetCircleRadius(result);

            Refresh();
        }

        #endregion

        private void brushRadiusTrackBar_Scroll(object sender, EventArgs e)
        {
            int result = (int)brushRadiusTrackBar.Value;
            brushRadiusTextBox.Text = result.ToString();
            appManager.SetCircleRadius(result);

            Refresh();
        }

        #endregion

        private void ConvolutionFilters_KeyDown(object sender, KeyEventArgs e)
        {
            skipMouseLeave = true;

            if (brushRadioButton.Checked)
            {
                if ((e.Control && e.Shift && e.KeyCode == Keys.Oemplus)
                    || (e.Control && e.KeyCode == Keys.Add))
                {
                    if (brushRadiusTrackBar.Value < brushRadiusTrackBar.Maximum)
                    {
                        brushRadiusTrackBar.Value += 1;
                        brushRadiusTrackBar_Scroll(this, EventArgs.Empty);
                    }
                }

                if ((e.Control && e.Shift && e.KeyCode == Keys.OemMinus)
                    || (e.Control && e.KeyCode == Keys.Subtract))
                {
                    if (brushRadiusTrackBar.Value > brushRadiusTrackBar.Minimum)
                    {
                        brushRadiusTrackBar.Value -= 1;
                        brushRadiusTrackBar_Scroll(this, EventArgs.Empty);
                    }
                }
            }

            if (e.Control && e.KeyCode == Keys.S)
                saveImageToolStripMenuItem_Click(sender, new EventArgs());

        }
    }
}