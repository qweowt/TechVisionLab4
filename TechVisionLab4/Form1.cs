using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Windows.Forms;

namespace TechVisionLab4
{
    public partial class Form1 : Form
    {
        Bitmap buffer;
        Bitmap filteredImage;
        Mat frame;
        VideoCapture videoCapture;
        bool camIsOn = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void RbImage_CheckedChanged(object sender, EventArgs e)
        {
            MultiButton.Text = "Select Image";
        }

        private void RbCam_CheckedChanged(object sender, EventArgs e)
        {
            MultiButton.Text = "Enable Camera";
        }

        private void MultiButton_Click(object sender, EventArgs e)
        {
            if (RbCam.Checked)
            {
                pictureBox1.Image = null;
                OnOffCam();
            }
            else if (RbImage.Checked)
            {
                SelectImage();
            }
            else
            {
                MessageBox.Show("Выберите Camera или Image");
            }
        }

        private void SelectImage()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string a = openFileDialog1.FileName;
                buffer = new Bitmap(a);
                pictureBox1.Image = buffer;
            }

        }

        private void OnOffCam()
        {
            if (camIsOn == false)
            {
                videoCapture = new VideoCapture(0);
                updateFrame.Start();
                camIsOn = true;
                MultiButton.Text = "Disable camera";
            }
            else
            {
                updateFrame.Stop();
                videoCapture?.Dispose();
                frame?.Dispose();
                camIsOn = false;
                MultiButton.Text = "Enable Camera";
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateFrame.Stop();
            videoCapture?.Dispose();
            frame?.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void updateFrame_Tick(object sender, EventArgs e)
        {
            try
            {
                frame = new Mat();
                videoCapture.Read(frame);

                if (!frame.Empty())
                {
                    pictureBox1.Image = BitmapConverter.ToBitmap(frame); // Отображение кадра на PictureBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                updateFrame.Stop();
            }
        }
    }
}
