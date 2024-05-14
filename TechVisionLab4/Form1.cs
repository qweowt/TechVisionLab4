using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Drawing;
using System.Windows.Forms;
using static OpenCvSharp.Stitcher;

namespace TechVisionLab4
{
    public partial class Form1 : Form
    {
        Bitmap buffer;
        Bitmap filteredImage;
        Mat frame;
        VideoCapture videoCapture;
        bool camIsOn = false;

        OpenCvSharp.Point point;

        public Form1()
        {
            InitializeComponent();
        }

        private void RbImage_CheckedChanged(object sender, EventArgs e)
        {
            MultiButton.Text = "Select Image";
            updateFrame.Stop();
        }

        private void RbCam_CheckedChanged(object sender, EventArgs e)
        {
            MultiButton.Text = "Enable Camera";
            updateFrame.Stop();
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
                updateFrame.Stop();
                videoCapture?.Dispose();
                frame?.Dispose();
                camIsOn = false;
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
                updateFrame.Start();
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

        private void updateFrame_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!camIsOn)
                {
                    frame = BitmapConverter.ToMat(buffer);
                }
                else
                {
                    frame = new Mat();
                    videoCapture.Read(frame);
                }

                if (!frame.Empty())
                {
                    if(PixelParm.Checked)
                    {
                        Vec3b pixelValue = frame.Get<Vec3b>(point.Y, point.X);
                        byte b = pixelValue.Item0;
                        byte r = pixelValue.Item1;
                        byte g = pixelValue.Item2;
                        string str = $"B: {b.ToString()} R: {r.ToString()} G: {g.ToString()}";
                        frame.PutText(str, point, new HersheyFonts(), 0.5, new Scalar(0, 0, 0));
                    }
                    pictureBox1.Image = BitmapConverter.ToBitmap(SetFilter(frame)); // Отображение кадра на PictureBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                updateFrame.Stop();
            }
        }

        private Mat SetFilter(Mat frame)
        {
            Mat newFrame = new Mat();
            switch (filtersCb.SelectedIndex)
            {
                case 0:
                    SetUIParam(filtersCb.SelectedIndex);
                    newFrame = frame;
                    break;
                case 1:
                    Cv2.CvtColor(frame, newFrame, ColorConversionCodes.RGB2GRAY);
                    SetUIParam(filtersCb.SelectedIndex);
                    break;
                case 2:
                    Scalar lowerBound = new Scalar(trackBarLR.Value, trackBarLG.Value, trackBarLG.Value); // Нижняя граница (синий цвет)
                    Scalar upperBound = new Scalar(trackBarUR.Value, trackBarUG.Value, trackBarUB.Value); // Верхняя граница (зеленый цвет)
                    Cv2.InRange(frame, lowerBound, upperBound, newFrame);
                    SetUIParam(filtersCb.SelectedIndex);
                    break;
                case 3:
                    SetUIParam(filtersCb.SelectedIndex);
                    Cv2.Canny(frame, newFrame, trackBarLR.Value, trackBarUR.Value);
                    break;
                case 4:
                    Mat filtered2D = new Mat(3, 3, MatType.CV_32F, new float[] { -1, -1, -1, -1, 8, -1, -1, -1, -1 }); // Создание матрицы ядра фильтра
                    SetUIParam(filtersCb.SelectedIndex);
                    Cv2.Filter2D(frame, newFrame, -1, filtered2D);
                    break;
                case 5:
                    OpenCvSharp.Size kernelSize = new OpenCvSharp.Size(trackBarBlur.Value, trackBarBlur.Value); // Размер ядра сглаживания
                    SetUIParam(filtersCb.SelectedIndex);
                    Cv2.Blur(frame, newFrame, kernelSize);
                    break;
                default:
                    SetUIParam(filtersCb.SelectedIndex);
                    newFrame = frame;
                    break;
            }

            return newFrame;
        }
        private void SetUIParam(int code)
        {
            switch (code)
            {
                case 0:
                    trackBarBlur.Visible = false;
                    trackBarLB.Visible = false;
                    trackBarLG.Visible = false;
                    trackBarLR.Visible = false;
                    trackBarUB.Visible = false;
                    trackBarUG.Visible = false;
                    trackBarUR.Visible = false;
                    break;
                case 1:
                    trackBarBlur.Visible = false;
                    trackBarLB.Visible = false;
                    trackBarLG.Visible = false;
                    trackBarLR.Visible = false;
                    trackBarUB.Visible = false;
                    trackBarUG.Visible = false;
                    trackBarUR.Visible = false;
                    break;
                case 2:
                    trackBarBlur.Visible = false;
                    trackBarLB.Visible = true;
                    trackBarLG.Visible = true;
                    trackBarLR.Visible = true;
                    trackBarUB.Visible = true;
                    trackBarUG.Visible = true;
                    trackBarUR.Visible = true;
                    break;
                case 3:
                    trackBarBlur.Visible = false;
                    trackBarLB.Visible = false;
                    trackBarLG.Visible = false;
                    trackBarLR.Visible = true;
                    trackBarUB.Visible = false;
                    trackBarUG.Visible = false;
                    trackBarUR.Visible = true;
                    break;
                case 4:
                    trackBarBlur.Visible = false;
                    trackBarLB.Visible = false;
                    trackBarLG.Visible = false;
                    trackBarLR.Visible = false;
                    trackBarUB.Visible = false;
                    trackBarUG.Visible = false;
                    trackBarUR.Visible = false;
                    break;
                case 5:
                    trackBarBlur.Visible = true;
                    trackBarLB.Visible = false;
                    trackBarLG.Visible = false;
                    trackBarLR.Visible = false;
                    trackBarUB.Visible = false;
                    trackBarUG.Visible = false;
                    trackBarUR.Visible = false;
                    break;
                default:
                    trackBarBlur.Visible = false;
                    trackBarLB.Visible = false;
                    trackBarLG.Visible = false;
                    trackBarLR.Visible = false;
                    trackBarUB.Visible = false;
                    trackBarUG.Visible = false;
                    trackBarUR.Visible = false;
                    break;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void filtersCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetUIParam(filtersCb.SelectedIndex);
        }

        private void ParamCheck(object sender, MouseEventArgs e)
        {
            if (PixelParm.Checked)
            {
                point = new OpenCvSharp.Point(e.X, e.Y);
            }
            else
                return;
        }
    }
}
