
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            BinParamBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarBlur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarUR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarUG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarUB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarLR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarLG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarLB).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 74);
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
            filtersCb.Location = new Point(668, 531);
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
            BinParamBox.Location = new Point(658, 298);
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
            PixelParm.Location = new Point(856, 535);
            PixelParm.Name = "PixelParm";
            PixelParm.Size = new Size(136, 19);
            PixelParm.TabIndex = 6;
            PixelParm.Text = "Read pixel parametrs";
            PixelParm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 563);
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
            Load += Form1_Load;
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
    }
}
