
namespace TechVisionLab4
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            RbImage = new RadioButton();
            RbCam = new RadioButton();
            MultiButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            updateFrame = new System.Windows.Forms.Timer(components);
            filtersCb = new ComboBox();
            BinParamBox = new GroupBox();
            trackBarBlur = new TrackBar();
            trackBarUR = new TrackBar();
            trackBarUG = new TrackBar();
            trackBarUB = new TrackBar();
            trackBarLR = new TrackBar();
            trackBarLG = new TrackBar();
            trackBarLB = new TrackBar();
            PixelParm = new CheckBox();
            numericRmin = new NumericUpDown();
            numericRmax = new NumericUpDown();
            numericGmax = new NumericUpDown();
            numericGmin = new NumericUpDown();
            numericBmax = new NumericUpDown();
            numericBmin = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ChBfilter = new CheckBox();
            SearchObjects = new CheckBox();
            label7 = new Label();
            label8 = new Label();
            numericSizeMax = new NumericUpDown();
            numericSizeMin = new NumericUpDown();
            numericU = new NumericUpDown();
            numericL = new NumericUpDown();
            DetectBtn = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            numericProc = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            BinParamBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarBlur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarUR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarUG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarUB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarLR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarLG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarLB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericRmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericRmax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericGmax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericGmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBmax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSizeMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSizeMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericU).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericProc).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(640, 480);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseMove += ParamCheck;
            // 
            // RbImage
            // 
            RbImage.AutoSize = true;
            RbImage.Location = new Point(17, 17);
            RbImage.Name = "RbImage";
            RbImage.Size = new Size(58, 19);
            RbImage.TabIndex = 1;
            RbImage.TabStop = true;
            RbImage.Text = "Image";
            RbImage.UseVisualStyleBackColor = true;
            RbImage.CheckedChanged += RbImage_CheckedChanged;
            // 
            // RbCam
            // 
            RbCam.AutoSize = true;
            RbCam.Location = new Point(17, 42);
            RbCam.Name = "RbCam";
            RbCam.Size = new Size(64, 19);
            RbCam.TabIndex = 2;
            RbCam.TabStop = true;
            RbCam.Text = "camera";
            RbCam.UseVisualStyleBackColor = true;
            RbCam.CheckedChanged += RbCam_CheckedChanged;
            // 
            // MultiButton
            // 
            MultiButton.Location = new Point(87, 17);
            MultiButton.Name = "MultiButton";
            MultiButton.Size = new Size(104, 44);
            MultiButton.TabIndex = 3;
            MultiButton.Text = "Button";
            MultiButton.UseVisualStyleBackColor = true;
            MultiButton.Click += MultiButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // updateFrame
            // 
            updateFrame.Interval = 34;
            updateFrame.Tick += updateFrame_Tick;
            // 
            // filtersCb
            // 
            filtersCb.FormattingEnabled = true;
            filtersCb.Items.AddRange(new object[] { "orginal", "CvtColor", "InRangeS", "Canny", "Filter2D", "Smooth" });
            filtersCb.Location = new Point(668, 524);
            filtersCb.Name = "filtersCb";
            filtersCb.Size = new Size(160, 23);
            filtersCb.TabIndex = 4;
            filtersCb.SelectedIndexChanged += filtersCb_SelectedIndexChanged;
            // 
            // BinParamBox
            // 
            BinParamBox.Controls.Add(trackBarBlur);
            BinParamBox.Controls.Add(trackBarUR);
            BinParamBox.Controls.Add(trackBarUG);
            BinParamBox.Controls.Add(trackBarUB);
            BinParamBox.Controls.Add(trackBarLR);
            BinParamBox.Controls.Add(trackBarLG);
            BinParamBox.Controls.Add(trackBarLB);
            BinParamBox.Location = new Point(658, 291);
            BinParamBox.Name = "BinParamBox";
            BinParamBox.Size = new Size(335, 227);
            BinParamBox.TabIndex = 5;
            BinParamBox.TabStop = false;
            BinParamBox.Text = "Filter Parametrs";
            // 
            // trackBarBlur
            // 
            trackBarBlur.Location = new Point(172, 175);
            trackBarBlur.Maximum = 100;
            trackBarBlur.Minimum = 1;
            trackBarBlur.Name = "trackBarBlur";
            trackBarBlur.Size = new Size(160, 45);
            trackBarBlur.TabIndex = 6;
            trackBarBlur.TickStyle = TickStyle.None;
            trackBarBlur.Value = 1;
            trackBarBlur.Visible = false;
            // 
            // trackBarUR
            // 
            trackBarUR.Location = new Point(172, 22);
            trackBarUR.Maximum = 255;
            trackBarUR.Name = "trackBarUR";
            trackBarUR.Size = new Size(160, 45);
            trackBarUR.TabIndex = 5;
            trackBarUR.Visible = false;
            // 
            // trackBarUG
            // 
            trackBarUG.Location = new Point(172, 73);
            trackBarUG.Maximum = 255;
            trackBarUG.Name = "trackBarUG";
            trackBarUG.Size = new Size(160, 45);
            trackBarUG.TabIndex = 4;
            trackBarUG.Visible = false;
            // 
            // trackBarUB
            // 
            trackBarUB.Location = new Point(172, 124);
            trackBarUB.Maximum = 255;
            trackBarUB.Name = "trackBarUB";
            trackBarUB.Size = new Size(160, 45);
            trackBarUB.TabIndex = 3;
            trackBarUB.Visible = false;
            // 
            // trackBarLR
            // 
            trackBarLR.Location = new Point(6, 22);
            trackBarLR.Maximum = 255;
            trackBarLR.Name = "trackBarLR";
            trackBarLR.Size = new Size(160, 45);
            trackBarLR.TabIndex = 2;
            trackBarLR.Visible = false;
            // 
            // trackBarLG
            // 
            trackBarLG.Location = new Point(6, 73);
            trackBarLG.Maximum = 255;
            trackBarLG.Name = "trackBarLG";
            trackBarLG.Size = new Size(160, 45);
            trackBarLG.TabIndex = 1;
            trackBarLG.Visible = false;
            // 
            // trackBarLB
            // 
            trackBarLB.Location = new Point(6, 124);
            trackBarLB.Maximum = 255;
            trackBarLB.Name = "trackBarLB";
            trackBarLB.Size = new Size(160, 45);
            trackBarLB.TabIndex = 0;
            trackBarLB.Visible = false;
            // 
            // PixelParm
            // 
            PixelParm.AutoSize = true;
            PixelParm.Location = new Point(856, 528);
            PixelParm.Name = "PixelParm";
            PixelParm.Size = new Size(136, 19);
            PixelParm.TabIndex = 6;
            PixelParm.Text = "Read pixel parametrs";
            PixelParm.UseVisualStyleBackColor = true;
            // 
            // numericRmin
            // 
            numericRmin.Location = new Point(668, 91);
            numericRmin.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericRmin.Name = "numericRmin";
            numericRmin.Size = new Size(53, 23);
            numericRmin.TabIndex = 7;
            // 
            // numericRmax
            // 
            numericRmax.Location = new Point(727, 91);
            numericRmax.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericRmax.Name = "numericRmax";
            numericRmax.Size = new Size(53, 23);
            numericRmax.TabIndex = 8;
            numericRmax.Value = new decimal(new int[] { 255, 0, 0, 0 });
            // 
            // numericGmax
            // 
            numericGmax.Location = new Point(727, 136);
            numericGmax.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericGmax.Name = "numericGmax";
            numericGmax.Size = new Size(53, 23);
            numericGmax.TabIndex = 10;
            numericGmax.Value = new decimal(new int[] { 255, 0, 0, 0 });
            // 
            // numericGmin
            // 
            numericGmin.Location = new Point(668, 136);
            numericGmin.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericGmin.Name = "numericGmin";
            numericGmin.Size = new Size(53, 23);
            numericGmin.TabIndex = 9;
            // 
            // numericBmax
            // 
            numericBmax.Location = new Point(727, 180);
            numericBmax.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericBmax.Name = "numericBmax";
            numericBmax.Size = new Size(53, 23);
            numericBmax.TabIndex = 12;
            numericBmax.Value = new decimal(new int[] { 255, 0, 0, 0 });
            // 
            // numericBmin
            // 
            numericBmin.Location = new Point(668, 180);
            numericBmin.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericBmin.Name = "numericBmin";
            numericBmin.Size = new Size(53, 23);
            numericBmin.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(668, 73);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 13;
            label1.Text = "Rmin";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(727, 73);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 14;
            label2.Text = "Rmax";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(727, 118);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 16;
            label3.Text = "Gmax";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(669, 118);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 15;
            label4.Text = "Gmin";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(727, 162);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 18;
            label5.Text = "Bmax";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(668, 162);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 17;
            label6.Text = "Bmin";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ChBfilter
            // 
            ChBfilter.AutoSize = true;
            ChBfilter.Location = new Point(669, 209);
            ChBfilter.Name = "ChBfilter";
            ChBfilter.Size = new Size(82, 19);
            ChBfilter.TabIndex = 19;
            ChBfilter.Text = "Color filter";
            ChBfilter.UseVisualStyleBackColor = true;
            // 
            // SearchObjects
            // 
            SearchObjects.AutoSize = true;
            SearchObjects.Location = new Point(797, 165);
            SearchObjects.Name = "SearchObjects";
            SearchObjects.Size = new Size(102, 19);
            SearchObjects.TabIndex = 20;
            SearchObjects.Text = "Search objects";
            SearchObjects.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(856, 118);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 28;
            label7.Text = "Size max";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.Location = new Point(798, 118);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 27;
            label8.Text = "Size min";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numericSizeMax
            // 
            numericSizeMax.Location = new Point(856, 136);
            numericSizeMax.Maximum = new decimal(new int[] { 480, 0, 0, 0 });
            numericSizeMax.Name = "numericSizeMax";
            numericSizeMax.Size = new Size(53, 23);
            numericSizeMax.TabIndex = 24;
            // 
            // numericSizeMin
            // 
            numericSizeMin.Location = new Point(797, 136);
            numericSizeMin.Maximum = new decimal(new int[] { 480, 0, 0, 0 });
            numericSizeMin.Name = "numericSizeMin";
            numericSizeMin.Size = new Size(53, 23);
            numericSizeMin.TabIndex = 23;
            // 
            // numericU
            // 
            numericU.Location = new Point(856, 91);
            numericU.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericU.Name = "numericU";
            numericU.Size = new Size(53, 23);
            numericU.TabIndex = 22;
            // 
            // numericL
            // 
            numericL.Location = new Point(797, 91);
            numericL.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericL.Name = "numericL";
            numericL.Size = new Size(53, 23);
            numericL.TabIndex = 21;
            // 
            // DetectBtn
            // 
            DetectBtn.Location = new Point(668, 234);
            DetectBtn.Name = "DetectBtn";
            DetectBtn.Size = new Size(204, 51);
            DetectBtn.TabIndex = 29;
            DetectBtn.Text = "Detect";
            DetectBtn.UseVisualStyleBackColor = true;
            DetectBtn.Click += DetectBtn_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(999, 17);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(500, 526);
            flowLayoutPanel1.TabIndex = 30;
            // 
            // numericProc
            // 
            numericProc.Location = new Point(878, 250);
            numericProc.Name = "numericProc";
            numericProc.Size = new Size(74, 23);
            numericProc.TabIndex = 31;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1507, 555);
            Controls.Add(numericProc);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(DetectBtn);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(numericSizeMax);
            Controls.Add(numericSizeMin);
            Controls.Add(numericU);
            Controls.Add(numericL);
            Controls.Add(SearchObjects);
            Controls.Add(ChBfilter);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericBmax);
            Controls.Add(numericBmin);
            Controls.Add(numericGmax);
            Controls.Add(numericGmin);
            Controls.Add(numericRmax);
            Controls.Add(numericRmin);
            Controls.Add(PixelParm);
            Controls.Add(BinParamBox);
            Controls.Add(filtersCb);
            Controls.Add(MultiButton);
            Controls.Add(RbCam);
            Controls.Add(RbImage);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "TechVisionLab4 Klimenko";
            FormClosing += MainForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            BinParamBox.ResumeLayout(false);
            BinParamBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarBlur).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarUR).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarUG).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarUB).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarLR).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarLG).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarLB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericRmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericRmax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericGmax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericGmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBmax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSizeMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSizeMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericU).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericL).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericProc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private PictureBox pictureBox1;
        private RadioButton RbImage;
        private RadioButton RbCam;
        private Button MultiButton;
        private OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer updateFrame;
        private ComboBox filtersCb;
        private GroupBox BinParamBox;
        private TrackBar trackBarUB;
        private TrackBar trackBarLR;
        private TrackBar trackBarLG;
        private TrackBar trackBarLB;
        private TrackBar trackBarUR;
        private TrackBar trackBarUG;
        private TrackBar trackBarBlur;
        private CheckBox PixelParm;
        private NumericUpDown numericRmin;
        private NumericUpDown numericRmax;
        private NumericUpDown numericGmax;
        private NumericUpDown numericGmin;
        private NumericUpDown numericBmax;
        private NumericUpDown numericBmin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox ChBfilter;
        private CheckBox SearchObjects;
        private Label label7;
        private Label label8;
        private NumericUpDown numericSizeMax;
        private NumericUpDown numericSizeMin;
        private NumericUpDown numericU;
        private NumericUpDown numericL;
        private Button DetectBtn;
        private FlowLayoutPanel flowLayoutPanel1;
        private NumericUpDown numericProc;
    }
}
