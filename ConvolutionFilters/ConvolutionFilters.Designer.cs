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
            chooseImageToolStripMenuItem = new ToolStripMenuItem();
            saveImageToolStripMenuItem = new ToolStripMenuItem();
            generate1ToolStripMenuItem = new ToolStripMenuItem();
            generate2ToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            mainTableLayoutPanel = new TableLayoutPanel();
            pictureBox = new PictureBox();
            histogramsTableLayoutPanel = new TableLayoutPanel();
            blueHistPictureBox = new PictureBox();
            greenHistPictureBox = new PictureBox();
            redHistPictureBox = new PictureBox();
            parametersTableLayoutPanel1 = new TableLayoutPanel();
            filterChoiceGroupBox = new GroupBox();
            customButton = new Button();
            denomNumericUpDown = new NumericUpDown();
            shiftNumericUpDown = new NumericUpDown();
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
            brushRadioButton = new RadioButton();
            brushRadiusTextBox = new TextBox();
            brushRadiusTrackBar = new TrackBar();
            wholeAreaRadioButton = new RadioButton();
            updateImageToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            histogramsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)blueHistPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greenHistPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)redHistPictureBox).BeginInit();
            parametersTableLayoutPanel1.SuspendLayout();
            filterChoiceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)denomNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shiftNumericUpDown).BeginInit();
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
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chooseImageToolStripMenuItem, saveImageToolStripMenuItem, generate1ToolStripMenuItem, generate2ToolStripMenuItem, updateImageToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // chooseImageToolStripMenuItem
            // 
            chooseImageToolStripMenuItem.Name = "chooseImageToolStripMenuItem";
            chooseImageToolStripMenuItem.Size = new Size(270, 34);
            chooseImageToolStripMenuItem.Text = "Choose image";
            chooseImageToolStripMenuItem.Click += chooseImageToolStripMenuItem_Click;
            // 
            // saveImageToolStripMenuItem
            // 
            saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            saveImageToolStripMenuItem.Size = new Size(270, 34);
            saveImageToolStripMenuItem.Text = "Save image";
            saveImageToolStripMenuItem.Click += saveImageToolStripMenuItem_Click;
            // 
            // generate1ToolStripMenuItem
            // 
            generate1ToolStripMenuItem.Name = "generate1ToolStripMenuItem";
            generate1ToolStripMenuItem.Size = new Size(270, 34);
            generate1ToolStripMenuItem.Text = "Generate1";
            generate1ToolStripMenuItem.Click += generate1ToolStripMenuItem_Click;
            // 
            // generate2ToolStripMenuItem
            // 
            generate2ToolStripMenuItem.Name = "generate2ToolStripMenuItem";
            generate2ToolStripMenuItem.Size = new Size(270, 34);
            generate2ToolStripMenuItem.Text = "Generate2";
            generate2ToolStripMenuItem.Click += generate2ToolStripMenuItem_Click;
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
            pictureBox.MouseLeave += pictureBox_MouseLeave;
            pictureBox.MouseMove += pictureBox_MouseMove;
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
            filterChoiceGroupBox.Controls.Add(customButton);
            filterChoiceGroupBox.Controls.Add(denomNumericUpDown);
            filterChoiceGroupBox.Controls.Add(shiftNumericUpDown);
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
            // customButton
            // 
            customButton.Enabled = false;
            customButton.Location = new Point(348, 200);
            customButton.Name = "customButton";
            customButton.Size = new Size(106, 34);
            customButton.TabIndex = 18;
            customButton.Text = "Apply";
            customButton.UseVisualStyleBackColor = true;
            customButton.Click += customButton_Click;
            // 
            // denomNumericUpDown
            // 
            denomNumericUpDown.DecimalPlaces = 2;
            denomNumericUpDown.Enabled = false;
            denomNumericUpDown.Location = new Point(319, 418);
            denomNumericUpDown.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            denomNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            denomNumericUpDown.Name = "denomNumericUpDown";
            denomNumericUpDown.Size = new Size(135, 31);
            denomNumericUpDown.TabIndex = 17;
            denomNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            denomNumericUpDown.ValueChanged += denomNumericUpDown_ValueChanged;
            // 
            // shiftNumericUpDown
            // 
            shiftNumericUpDown.DecimalPlaces = 2;
            shiftNumericUpDown.Location = new Point(319, 380);
            shiftNumericUpDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            shiftNumericUpDown.Minimum = new decimal(new int[] { 255, 0, 0, int.MinValue });
            shiftNumericUpDown.Name = "shiftNumericUpDown";
            shiftNumericUpDown.Size = new Size(135, 31);
            shiftNumericUpDown.TabIndex = 16;
            shiftNumericUpDown.ValueChanged += shiftNumericUpDown_ValueChanged;
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
            autoDenomCheckBox.CheckedChanged += autoDenomCheckBox_CheckedChanged;
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
            filterMatrixPanel.Location = new Point(6, 240);
            filterMatrixPanel.Name = "filterMatrixPanel";
            filterMatrixPanel.Size = new Size(436, 124);
            filterMatrixPanel.TabIndex = 12;
            // 
            // numericUpDown22
            // 
            numericUpDown22.DecimalPlaces = 2;
            numericUpDown22.Location = new Point(298, 90);
            numericUpDown22.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown22.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            numericUpDown22.Name = "numericUpDown22";
            numericUpDown22.Size = new Size(135, 31);
            numericUpDown22.TabIndex = 8;
            // 
            // numericUpDown21
            // 
            numericUpDown21.DecimalPlaces = 2;
            numericUpDown21.Location = new Point(149, 90);
            numericUpDown21.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown21.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            numericUpDown21.Name = "numericUpDown21";
            numericUpDown21.Size = new Size(135, 31);
            numericUpDown21.TabIndex = 7;
            // 
            // numericUpDown20
            // 
            numericUpDown20.DecimalPlaces = 2;
            numericUpDown20.Location = new Point(0, 90);
            numericUpDown20.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown20.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            numericUpDown20.Name = "numericUpDown20";
            numericUpDown20.Size = new Size(135, 31);
            numericUpDown20.TabIndex = 6;
            // 
            // numericUpDown12
            // 
            numericUpDown12.DecimalPlaces = 2;
            numericUpDown12.Location = new Point(298, 45);
            numericUpDown12.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown12.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            numericUpDown12.Name = "numericUpDown12";
            numericUpDown12.Size = new Size(135, 31);
            numericUpDown12.TabIndex = 5;
            // 
            // numericUpDown11
            // 
            numericUpDown11.DecimalPlaces = 2;
            numericUpDown11.Location = new Point(149, 45);
            numericUpDown11.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown11.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            numericUpDown11.Name = "numericUpDown11";
            numericUpDown11.Size = new Size(135, 31);
            numericUpDown11.TabIndex = 4;
            // 
            // numericUpDown10
            // 
            numericUpDown10.DecimalPlaces = 2;
            numericUpDown10.Location = new Point(0, 45);
            numericUpDown10.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown10.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            numericUpDown10.Name = "numericUpDown10";
            numericUpDown10.Size = new Size(135, 31);
            numericUpDown10.TabIndex = 3;
            // 
            // numericUpDown01
            // 
            numericUpDown01.Anchor = AnchorStyles.Top;
            numericUpDown01.DecimalPlaces = 2;
            numericUpDown01.Location = new Point(151, 0);
            numericUpDown01.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown01.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            numericUpDown01.Name = "numericUpDown01";
            numericUpDown01.Size = new Size(135, 31);
            numericUpDown01.TabIndex = 1;
            // 
            // numericUpDown02
            // 
            numericUpDown02.DecimalPlaces = 2;
            numericUpDown02.Location = new Point(298, 0);
            numericUpDown02.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown02.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            numericUpDown02.Name = "numericUpDown02";
            numericUpDown02.Size = new Size(135, 31);
            numericUpDown02.TabIndex = 2;
            // 
            // numericUpDown00
            // 
            numericUpDown00.DecimalPlaces = 3;
            numericUpDown00.Location = new Point(0, 0);
            numericUpDown00.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown00.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
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
            IdentityRadioButton.Text = "&Identity";
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
            blurRadioButton.Text = "&Blur";
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
            sharpenRadioButton.Text = "&Sharpen";
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
            reliefRadioButton.Text = "&Relief";
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
            edgeDetectionRadioButton.Text = "&Edges detection";
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
            customRadioButton.Text = "&Custom";
            customRadioButton.UseVisualStyleBackColor = true;
            customRadioButton.CheckedChanged += customFilterChanged;
            // 
            // filterAreaGroupBox
            // 
            filterAreaGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            filterAreaGroupBox.Controls.Add(brushRadioButton);
            filterAreaGroupBox.Controls.Add(brushRadiusTextBox);
            filterAreaGroupBox.Controls.Add(brushRadiusTrackBar);
            filterAreaGroupBox.Controls.Add(wholeAreaRadioButton);
            filterAreaGroupBox.Location = new Point(3, 3);
            filterAreaGroupBox.Name = "filterAreaGroupBox";
            filterAreaGroupBox.Size = new Size(460, 194);
            filterAreaGroupBox.TabIndex = 3;
            filterAreaGroupBox.TabStop = false;
            filterAreaGroupBox.Text = "Filter application area";
            // 
            // brushRadioButton
            // 
            brushRadioButton.AutoSize = true;
            brushRadioButton.Location = new Point(6, 65);
            brushRadioButton.Name = "brushRadioButton";
            brushRadioButton.Size = new Size(149, 29);
            brushRadioButton.TabIndex = 3;
            brushRadioButton.TabStop = true;
            brushRadioButton.Text = "Circular brush:";
            brushRadioButton.UseVisualStyleBackColor = true;
            brushRadioButton.CheckedChanged += brushRadioButton_CheckedChanged;
            // 
            // brushRadiusTextBox
            // 
            brushRadiusTextBox.Enabled = false;
            brushRadiusTextBox.Location = new Point(371, 100);
            brushRadiusTextBox.Name = "brushRadiusTextBox";
            brushRadiusTextBox.Size = new Size(52, 31);
            brushRadiusTextBox.TabIndex = 13;
            brushRadiusTextBox.Text = "1";
            brushRadiusTextBox.TextAlign = HorizontalAlignment.Center;
            brushRadiusTextBox.Enter += TextBox_Enter;
            brushRadiusTextBox.KeyPress += integerTextBox_KeyPress;
            brushRadiusTextBox.Validating += validatingTextBox;
            brushRadiusTextBox.Validated += brushRadiusTextBox_Validated;
            // 
            // brushRadiusTrackBar
            // 
            brushRadiusTrackBar.Enabled = false;
            brushRadiusTrackBar.Location = new Point(21, 100);
            brushRadiusTrackBar.Maximum = 500;
            brushRadiusTrackBar.Minimum = 1;
            brushRadiusTrackBar.Name = "brushRadiusTrackBar";
            brushRadiusTrackBar.Size = new Size(344, 69);
            brushRadiusTrackBar.TabIndex = 12;
            brushRadiusTrackBar.Value = 1;
            brushRadiusTrackBar.Scroll += brushRadiusTrackBar_Scroll;
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
            // updateImageToolStripMenuItem
            // 
            updateImageToolStripMenuItem.Name = "updateImageToolStripMenuItem";
            updateImageToolStripMenuItem.Size = new Size(270, 34);
            updateImageToolStripMenuItem.Text = "Update image";
            updateImageToolStripMenuItem.Click += updateImageToolStripMenuItem_Click;
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
            KeyPreview = true;
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConvolutionFilters";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConvolutionFilters";
            KeyDown += ConvolutionFilters_KeyDown;
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
            ((System.ComponentModel.ISupportInitialize)denomNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)shiftNumericUpDown).EndInit();
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
        private TextBox brushRadiusTextBox;
        private Panel filterMatrixPanel;
        private NumericUpDown numericUpDown00;
        private RadioButton brushRadioButton;
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
        private NumericUpDown denomNumericUpDown;
        private NumericUpDown shiftNumericUpDown;
        private Button customButton;
        private ToolStripMenuItem chooseImageToolStripMenuItem;
        private ToolStripMenuItem saveImageToolStripMenuItem;
        private ToolStripMenuItem generate1ToolStripMenuItem;
        private ToolStripMenuItem generate2ToolStripMenuItem;
        private ToolStripMenuItem updateImageToolStripMenuItem;
    }
}