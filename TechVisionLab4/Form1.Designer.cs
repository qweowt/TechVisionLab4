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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            updateFrame.Interval = 50;
            updateFrame.Tick += updateFrame_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 566);
            Controls.Add(MultiButton);
            Controls.Add(RbCam);
            Controls.Add(RbImage);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "TechVisionLab4 Klimenko";
            FormClosing += MainForm_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}
