namespace ConvolutionFilters
{
    partial class ConvolutionFilters
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            mainTableLayoutPanel = new TableLayoutPanel();
            pictureBox = new PictureBox();
            histogramsTableLayoutPanel = new TableLayoutPanel();
            blueHistPictureBox = new PictureBox();
            greenHistPictureBox = new PictureBox();
            redHistPictureBox = new PictureBox();
            parametersTableLayoutPanel1 = new TableLayoutPanel();
            filterChoiceGroupBox = new GroupBox();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            autoDenomCheckBox = new CheckBox();
            filterDenominatorLabel = new Label();
            filterShiftLabel = new Label();
            filterMatrixPanel = new Panel();
            numericUpDown22 = new NumericUpDown();
            numericUpDown21 = new NumericUpDown();
            numericUpDown20 = new NumericUpDown();
            numericUpDown12 = new NumericUpDown();
            numericUpDown11 = new NumericUpDown();
            numericUpDown10 = new NumericUpDown();
            numericUpDown01 = new NumericUpDown();
            numericUpDown02 = new NumericUpDown();
            numericUpDown00 = new NumericUpDown();
            IdentityRadioButton = new RadioButton();
            blurRadioButton = new RadioButton();
            sharpenRadioButton = new RadioButton();
            reliefRadioButton = new RadioButton();
            edgeDetectionRadioButton = new RadioButton();
            customRadioButton = new RadioButton();
            filterAreaGroupBox = new GroupBox();
            brushRradioButton = new RadioButton();
            textBox1 = new TextBox();
            brushRadiusTrackBar = new TrackBar();
            wholeAreaRadioButton = new RadioButton();
            menuStrip.SuspendLayout();
            mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            histogramsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)blueHistPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greenHistPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)redHistPictureBox).BeginInit();
            parametersTableLayoutPanel1.SuspendLayout();
            filterChoiceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            filterMatrixPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown22).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown01).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown02).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown00).BeginInit();
            filterAreaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)brushRadiusTrackBar).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1758, 33);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Location = new Point(0, 889);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1758, 22);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "statusStrip";
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 3;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 472F));
            mainTableLayoutPanel.Controls.Add(pictureBox, 0, 0);
            mainTableLayoutPanel.Controls.Add(histogramsTableLayoutPanel, 1, 0);
            mainTableLayoutPanel.Controls.Add(parametersTableLayoutPanel1, 2, 0);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 33);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 1;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Size = new Size(1758, 856);
            mainTableLayoutPanel.TabIndex = 2;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(850, 850);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Paint += pictureBox_Paint;
            // 
            // histogramsTableLayoutPanel
            // 
            histogramsTableLayoutPanel.ColumnCount = 1;
            histogramsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            histogramsTableLayoutPanel.Controls.Add(blueHistPictureBox, 0, 2);
            histogramsTableLayoutPanel.Controls.Add(greenHistPictureBox, 0, 1);
            histogramsTableLayoutPanel.Controls.Add(redHistPictureBox, 0, 0);
            histogramsTableLayoutPanel.Dock = DockStyle.Fill;
            histogramsTableLayoutPanel.Location = new Point(859, 3);
            histogramsTableLayoutPanel.Name = "histogramsTableLayoutPanel";
            histogramsTableLayoutPanel.RowCount = 4;
            histogramsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            histogramsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            histogramsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            histogramsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            histogramsTableLayoutPanel.Size = new Size(424, 850);
            histogramsTableLayoutPanel.TabIndex = 1;
            // 
            // blueHistPictureBox
            // 
            blueHistPictureBox.BackColor = Color.White;
            blueHistPictureBox.Dock = DockStyle.Fill;
            blueHistPictureBox.Location = new Point(3, 427);
            blueHistPictureBox.Name = "blueHistPictureBox";
            blueHistPictureBox.Size = new Size(418, 206);
            blueHistPictureBox.TabIndex = 20;
            blueHistPictureBox.TabStop = false;
            blueHistPictureBox.Paint += blueHistPictureBox_Paint;
            // 
            // greenHistPictureBox
            // 
            greenHistPictureBox.BackColor = Color.White;
            greenHistPictureBox.Dock = DockStyle.Fill;
            greenHistPictureBox.Location = new Point(3, 215);
            greenHistPictureBox.Name = "greenHistPictureBox";
            greenHistPictureBox.Size = new Size(418, 206);
            greenHistPictureBox.TabIndex = 19;
            greenHistPictureBox.TabStop = false;
            greenHistPictureBox.Paint += greenHistPictureBox_Paint;
            // 
            // redHistPictureBox
            // 
            redHistPictureBox.BackColor = Color.White;
            redHistPictureBox.Dock = DockStyle.Fill;
            redHistPictureBox.Location = new Point(3, 3);
            redHistPictureBox.Name = "redHistPictureBox";
            redHistPictureBox.Size = new Size(418, 206);
            redHistPictureBox.TabIndex = 18;
            redHistPictureBox.TabStop = false;
            redHistPictureBox.Paint += redHistPictureBox_Paint;
            // 
            // parametersTableLayoutPanel1
            // 
            parametersTableLayoutPanel1.ColumnCount = 1;
            parametersTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            parametersTableLayoutPanel1.Controls.Add(filterChoiceGroupBox, 0, 1);
            parametersTableLayoutPanel1.Controls.Add(filterAreaGroupBox, 0, 0);
            parametersTableLayoutPanel1.Dock = DockStyle.Fill;
            parametersTableLayoutPanel1.Location = new Point(1289, 3);
            parametersTableLayoutPanel1.Name = "parametersTableLayoutPanel1";
            parametersTableLayoutPanel1.RowCount = 3;
            parametersTableLayoutPanel1.RowStyles.Add(new RowStyle());
            parametersTableLayoutPanel1.RowStyles.Add(new RowStyle());
            parametersTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            parametersTableLayoutPanel1.Size = new Size(466, 850);
            parametersTableLayoutPanel1.TabIndex = 2;
            // 
            // filterChoiceGroupBox
            // 
            filterChoiceGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            filterChoiceGroupBox.Controls.Add(numericUpDown2);
            filterChoiceGroupBox.Controls.Add(numericUpDown1);
            filterChoiceGroupBox.Controls.Add(autoDenomCheckBox);
            filterChoiceGroupBox.Controls.Add(filterDenominatorLabel);
            filterChoiceGroupBox.Controls.Add(filterShiftLabel);
            filterChoiceGroupBox.Controls.Add(filterMatrixPanel);
            filterChoiceGroupBox.Controls.Add(IdentityRadioButton);
            filterChoiceGroupBox.Controls.Add(blurRadioButton);
            filterChoiceGroupBox.Controls.Add(sharpenRadioButton);
            filterChoiceGroupBox.Controls.Add(reliefRadioButton);
            filterChoiceGroupBox.Controls.Add(edgeDetectionRadioButton);
            filterChoiceGroupBox.Controls.Add(customRadioButton);
            filterChoiceGroupBox.Location = new Point(3, 203);
            filterChoiceGroupBox.Name = "filterChoiceGroupBox";
            filterChoiceGroupBox.Size = new Size(460, 490);
            filterChoiceGroupBox.TabIndex = 4;
            filterChoiceGroupBox.TabStop = false;
            filterChoiceGroupBox.Text = "Convolution filter choice";
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Enabled = false;
            numericUpDown2.Location = new Point(319, 418);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(135, 31);
            numericUpDown2.TabIndex = 17;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(319, 380);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(135, 31);
            numericUpDown1.TabIndex = 16;
            // 
            // autoDenomCheckBox
            // 
            autoDenomCheckBox.AutoSize = true;
            autoDenomCheckBox.Checked = true;
            autoDenomCheckBox.CheckState = CheckState.Checked;
            autoDenomCheckBox.Location = new Point(6, 455);
            autoDenomCheckBox.Name = "autoDenomCheckBox";
            autoDenomCheckBox.Size = new Size(386, 29);
            autoDenomCheckBox.TabIndex = 15;
            autoDenomCheckBox.Text = "Atomatic determination of the denominator";
            autoDenomCheckBox.UseVisualStyleBackColor = true;
            // 
            // filterDenominatorLabel
            // 
            filterDenominatorLabel.AutoSize = true;
            filterDenominatorLabel.Location = new Point(6, 418);
            filterDenominatorLabel.Name = "filterDenominatorLabel";
            filterDenominatorLabel.Size = new Size(162, 25);
            filterDenominatorLabel.TabIndex = 14;
            filterDenominatorLabel.Text = "Filter denominator:";
            // 
            // filterShiftLabel
            // 
            filterShiftLabel.AutoSize = true;
            filterShiftLabel.Location = new Point(6, 382);
            filterShiftLabel.Name = "filterShiftLabel";
            filterShiftLabel.Size = new Size(93, 25);
            filterShiftLabel.TabIndex = 13;
            filterShiftLabel.Text = "Filter shift:";
            // 
            // filterMatrixPanel
            // 
            filterMatrixPanel.Anchor = AnchorStyles.Top;
            filterMatrixPanel.AutoSize = true;
            filterMatrixPanel.Controls.Add(numericUpDown22);
            filterMatrixPanel.Controls.Add(numericUpDown21);
            filterMatrixPanel.Controls.Add(numericUpDown20);
            filterMatrixPanel.Controls.Add(numericUpDown12);
            filterMatrixPanel.Controls.Add(numericUpDown11);
            filterMatrixPanel.Controls.Add(numericUpDown10);
            filterMatrixPanel.Controls.Add(numericUpDown01);
            filterMatrixPanel.Controls.Add(numericUpDown02);
            filterMatrixPanel.Controls.Add(numericUpDown00);
            filterMatrixPanel.Enabled = false;
            filterMatrixPanel.Location = new Point(50, 240);
            filterMatrixPanel.Name = "filterMatrixPanel";
            filterMatrixPanel.Size = new Size(436, 124);
            filterMatrixPanel.TabIndex = 12;
            // 
            // numericUpDown22
            // 
            numericUpDown22.DecimalPlaces = 2;
            numericUpDown22.Location = new Point(298, 90);
            numericUpDown22.Name = "numericUpDown22";
            numericUpDown22.Size = new Size(135, 31);
            numericUpDown22.TabIndex = 9;
            // 
            // numericUpDown21
            // 
            numericUpDown21.DecimalPlaces = 2;
            numericUpDown21.Location = new Point(149, 90);
            numericUpDown21.Name = "numericUpDown21";
            numericUpDown21.Size = new Size(135, 31);
            numericUpDown21.TabIndex = 8;
            // 
            // numericUpDown20
            // 
            numericUpDown20.DecimalPlaces = 2;
            numericUpDown20.Location = new Point(0, 90);
            numericUpDown20.Name = "numericUpDown20";
            numericUpDown20.Size = new Size(135, 31);
            numericUpDown20.TabIndex = 7;
            // 
            // numericUpDown12
            // 
            numericUpDown12.DecimalPlaces = 2;
            numericUpDown12.Location = new Point(298, 45);
            numericUpDown12.Name = "numericUpDown12";
            numericUpDown12.Size = new Size(135, 31);
            numericUpDown12.TabIndex = 6;
            // 
            // numericUpDown11
            // 
            numericUpDown11.DecimalPlaces = 2;
            numericUpDown11.Location = new Point(149, 45);
            numericUpDown11.Name = "numericUpDown11";
            numericUpDown11.Size = new Size(135, 31);
            numericUpDown11.TabIndex = 5;
            // 
            // numericUpDown10
            // 
            numericUpDown10.DecimalPlaces = 2;
            numericUpDown10.Location = new Point(0, 45);
            numericUpDown10.Name = "numericUpDown10";
            numericUpDown10.Size = new Size(135, 31);
            numericUpDown10.TabIndex = 4;
            // 
            // numericUpDown01
            // 
            numericUpDown01.Anchor = AnchorStyles.Top;
            numericUpDown01.DecimalPlaces = 2;
            numericUpDown01.Location = new Point(151, 0);
            numericUpDown01.Name = "numericUpDown01";
            numericUpDown01.Size = new Size(135, 31);
            numericUpDown01.TabIndex = 2;
            // 
            // numericUpDown02
            // 
            numericUpDown02.DecimalPlaces = 2;
            numericUpDown02.Location = new Point(298, 0);
            numericUpDown02.Name = "numericUpDown02";
            numericUpDown02.Size = new Size(135, 31);
            numericUpDown02.TabIndex = 3;
            // 
            // numericUpDown00
            // 
            numericUpDown00.DecimalPlaces = 3;
            numericUpDown00.Location = new Point(0, 0);
            numericUpDown00.Name = "numericUpDown00";
            numericUpDown00.Size = new Size(135, 31);
            numericUpDown00.TabIndex = 0;
            // 
            // IdentityRadioButton
            // 
            IdentityRadioButton.AutoSize = true;
            IdentityRadioButton.Checked = true;
            IdentityRadioButton.Location = new Point(6, 30);
            IdentityRadioButton.Name = "IdentityRadioButton";
            IdentityRadioButton.Size = new Size(97, 29);
            IdentityRadioButton.TabIndex = 11;
            IdentityRadioButton.TabStop = true;
            IdentityRadioButton.Text = "Identity";
            IdentityRadioButton.UseVisualStyleBackColor = true;
            IdentityRadioButton.CheckedChanged += filterChanged;
            // 
            // blurRadioButton
            // 
            blurRadioButton.AutoSize = true;
            blurRadioButton.Location = new Point(6, 65);
            blurRadioButton.Name = "blurRadioButton";
            blurRadioButton.Size = new Size(67, 29);
            blurRadioButton.TabIndex = 10;
            blurRadioButton.Text = "Blur";
            blurRadioButton.UseVisualStyleBackColor = true;
            blurRadioButton.CheckedChanged += filterChanged;
            // 
            // sharpenRadioButton
            // 
            sharpenRadioButton.AutoSize = true;
            sharpenRadioButton.Location = new Point(6, 100);
            sharpenRadioButton.Name = "sharpenRadioButton";
            sharpenRadioButton.Size = new Size(102, 29);
            sharpenRadioButton.TabIndex = 9;
            sharpenRadioButton.Text = "Sharpen";
            sharpenRadioButton.UseVisualStyleBackColor = true;
            sharpenRadioButton.CheckedChanged += filterChanged;
            // 
            // reliefRadioButton
            // 
            reliefRadioButton.AutoSize = true;
            reliefRadioButton.Location = new Point(6, 135);
            reliefRadioButton.Name = "reliefRadioButton";
            reliefRadioButton.Size = new Size(79, 29);
            reliefRadioButton.TabIndex = 8;
            reliefRadioButton.Text = "Relief";
            reliefRadioButton.UseVisualStyleBackColor = true;
            reliefRadioButton.CheckedChanged += filterChanged;
            // 
            // edgeDetectionRadioButton
            // 
            edgeDetectionRadioButton.AutoSize = true;
            edgeDetectionRadioButton.Location = new Point(6, 170);
            edgeDetectionRadioButton.Name = "edgeDetectionRadioButton";
            edgeDetectionRadioButton.Size = new Size(164, 29);
            edgeDetectionRadioButton.TabIndex = 7;
            edgeDetectionRadioButton.Text = "Edges detection";
            edgeDetectionRadioButton.UseVisualStyleBackColor = true;
            edgeDetectionRadioButton.CheckedChanged += filterChanged;
            // 
            // customRadioButton
            // 
            customRadioButton.AutoSize = true;
            customRadioButton.Location = new Point(6, 205);
            customRadioButton.Name = "customRadioButton";
            customRadioButton.Size = new Size(99, 29);
            customRadioButton.TabIndex = 6;
            customRadioButton.Text = "Custom";
            customRadioButton.UseVisualStyleBackColor = true;
            customRadioButton.CheckedChanged += filterChanged;
            // 
            // filterAreaGroupBox
            // 
            filterAreaGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            filterAreaGroupBox.Controls.Add(brushRradioButton);
            filterAreaGroupBox.Controls.Add(textBox1);
            filterAreaGroupBox.Controls.Add(brushRadiusTrackBar);
            filterAreaGroupBox.Controls.Add(wholeAreaRadioButton);
            filterAreaGroupBox.Location = new Point(3, 3);
            filterAreaGroupBox.Name = "filterAreaGroupBox";
            filterAreaGroupBox.Size = new Size(460, 194);
            filterAreaGroupBox.TabIndex = 3;
            filterAreaGroupBox.TabStop = false;
            filterAreaGroupBox.Text = "Filter application area";
            // 
            // brushRradioButton
            // 
            brushRradioButton.AutoSize = true;
            brushRradioButton.Location = new Point(6, 65);
            brushRradioButton.Name = "brushRradioButton";
            brushRradioButton.Size = new Size(149, 29);
            brushRradioButton.TabIndex = 3;
            brushRradioButton.TabStop = true;
            brushRradioButton.Text = "Circular brush:";
            brushRradioButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(402, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(52, 31);
            textBox1.TabIndex = 13;
            textBox1.Text = "1";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // brushRadiusTrackBar
            // 
            brushRadiusTrackBar.Enabled = false;
            brushRadiusTrackBar.Location = new Point(21, 100);
            brushRadiusTrackBar.Maximum = 100;
            brushRadiusTrackBar.Minimum = 1;
            brushRadiusTrackBar.Name = "brushRadiusTrackBar";
            brushRadiusTrackBar.Size = new Size(375, 69);
            brushRadiusTrackBar.TabIndex = 12;
            brushRadiusTrackBar.Value = 1;
            // 
            // wholeAreaRadioButton
            // 
            wholeAreaRadioButton.AutoSize = true;
            wholeAreaRadioButton.Checked = true;
            wholeAreaRadioButton.Location = new Point(6, 30);
            wholeAreaRadioButton.Name = "wholeAreaRadioButton";
            wholeAreaRadioButton.Size = new Size(126, 29);
            wholeAreaRadioButton.TabIndex = 5;
            wholeAreaRadioButton.TabStop = true;
            wholeAreaRadioButton.Text = "Whole area";
            wholeAreaRadioButton.UseVisualStyleBackColor = true;
            // 
            // ConvolutionFilters
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1758, 911);
            Controls.Add(mainTableLayoutPanel);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            Name = "ConvolutionFilters";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConvolutionFilters";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            mainTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            histogramsTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)blueHistPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)greenHistPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)redHistPictureBox).EndInit();
            parametersTableLayoutPanel1.ResumeLayout(false);
            filterChoiceGroupBox.ResumeLayout(false);
            filterChoiceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            filterMatrixPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown22).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown21).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown20).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown12).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown11).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown10).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown01).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown02).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown00).EndInit();
            filterAreaGroupBox.ResumeLayout(false);
            filterAreaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)brushRadiusTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private StatusStrip statusStrip;
        private TableLayoutPanel mainTableLayoutPanel;
        private PictureBox pictureBox;
        private TableLayoutPanel histogramsTableLayoutPanel;
        private TableLayoutPanel parametersTableLayoutPanel1;
        private GroupBox filterChoiceGroupBox;
        private RadioButton IdentityRadioButton;
        private RadioButton blurRadioButton;
        private RadioButton sharpenRadioButton;
        private RadioButton reliefRadioButton;
        private RadioButton edgeDetectionRadioButton;
        private RadioButton customRadioButton;
        private GroupBox filterAreaGroupBox;
        private TrackBar brushRadiusTrackBar;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton wholeAreaRadioButton;
        private TextBox textBox1;
        private Panel filterMatrixPanel;
        private NumericUpDown numericUpDown00;
        private RadioButton brushRradioButton;
        private NumericUpDown numericUpDown01;
        private NumericUpDown numericUpDown02;
        private NumericUpDown numericUpDown22;
        private NumericUpDown numericUpDown21;
        private NumericUpDown numericUpDown20;
        private NumericUpDown numericUpDown12;
        private NumericUpDown numericUpDown11;
        private NumericUpDown numericUpDown10;
        private CheckBox autoDenomCheckBox;
        private Label filterDenominatorLabel;
        private Label filterShiftLabel;
        private PictureBox blueHistPictureBox;
        private PictureBox greenHistPictureBox;
        private PictureBox redHistPictureBox;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
    }
}