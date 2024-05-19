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

        List<string> signName = new List<string> { "Brick", "Forward", "Stop" };

        OpenCvSharp.Point point;

        OpenCvSharp.Point[][] contours;
        HierarchyIndex[] hierarchy;
        OpenCvSharp.Rect rect;
        List<OpenCvSharp.Rect> rectList;

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
                    if (PixelParm.Checked)
                    {
                        Vec3b pixelValue = frame.Get<Vec3b>(point.Y, point.X);
                        byte b = pixelValue.Item0;
                        byte r = pixelValue.Item1;
                        byte g = pixelValue.Item2;
                        string str = $"B: {b.ToString()} R: {r.ToString()} G: {g.ToString()}";
                        frame.PutText(str, point, new HersheyFonts(), 0.5, new Scalar(0, 0, 0));
                    }
                    if (ChBfilter.Checked)
                    {
                        for (int i = 0; i < frame.Width; i++)
                        {
                            for (int j = 0; j < frame.Height; j++)
                            {
                                Vec3b pixelValue = frame.Get<Vec3b>(j, i);
                                byte b = pixelValue.Item0;
                                byte r = pixelValue.Item1;
                                byte g = pixelValue.Item2;

                                if (b < numericBmin.Value || b > numericBmax.Value ||
                                    r < numericRmin.Value || r > numericRmax.Value ||
                                    g < numericGmin.Value || g > numericGmax.Value)
                                    frame.Set(j, i, new Vec3b(0, 0, 0));
                            }
                        }
                    }

                    if (SearchObjects.Checked)
                    {
                        Mat findObjectMat = new Mat();
                        Cv2.Canny(frame, findObjectMat, (int)numericL.Value, (int)numericU.Value);

                        Cv2.FindContours(findObjectMat, out contours, out hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxTC89KCOS);
                        rectList = new List<OpenCvSharp.Rect>();
                        foreach (OpenCvSharp.Point[] contour in contours)
                        {
                            rect = Cv2.BoundingRect(contour);

                            int max = (int)numericSizeMax.Value;
                            int min = (int)numericSizeMin.Value;

                            if (rect.Width > min && rect.Height > min && rect.Width < max && rect.Height < max)
                            {
                                rectList.Add(rect);

                                frame.PutText(rect.Height.ToString() + " " + rect.Width.ToString(), new OpenCvSharp.Point(rect.X, rect.Y - 2), HersheyFonts.HersheySimplex, 0.5, new Scalar(0, 0, 0));
                                frame.Rectangle(rect, new Scalar(0, 0, 0));
                            }
                        }
                    }

                    pictureBox1.Image = BitmapConverter.ToBitmap(SetFilter(frame));
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
                    Scalar lowerBound = new Scalar(trackBarLR.Value, trackBarLG.Value, trackBarLG.Value);
                    Scalar upperBound = new Scalar(trackBarUR.Value, trackBarUG.Value, trackBarUB.Value);
                    Cv2.InRange(frame, lowerBound, upperBound, newFrame);
                    SetUIParam(filtersCb.SelectedIndex);
                    break;
                case 3:
                    SetUIParam(filtersCb.SelectedIndex);
                    Cv2.Canny(frame, newFrame, trackBarLR.Value, trackBarUR.Value);
                    break;
                case 4:
                    Mat filtered2D = new Mat(3, 3, MatType.CV_32F, new float[] { -1, -1, -1, -1, 8, -1, -1, -1, -1 });
                    SetUIParam(filtersCb.SelectedIndex);
                    Cv2.Filter2D(frame, newFrame, -1, filtered2D);
                    break;
                case 5:
                    OpenCvSharp.Size kernelSize = new OpenCvSharp.Size(trackBarBlur.Value, trackBarBlur.Value);
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

        private void filtersCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetUIParam(filtersCb.SelectedIndex);
        }

        private void ParamCheck(object sender, MouseEventArgs e)
        {
            if (PixelParm.Checked)
                point = new OpenCvSharp.Point(e.X, e.Y);
            else
                return;
        }

        private void DetectBtn_Click(object sender, EventArgs e)
        {
            if (SearchObjects.Checked && rect != null)
            {
                string[] maskFiles = Directory.GetFiles(@"C:\Users\Никита\Documents\GitHub\TechVisionLab4\TechVisionLab4\bin\Debug\net8.0-windows\Templates", "*.png");
                string[] templateFiles = Directory.GetFiles(@"C:\Users\Никита\Documents\GitHub\TechVisionLab4\TechVisionLab4\bin\Debug\net8.0-windows\Templates", "*.png");
                int tagCount = 0;
                flowLayoutPanel1.Controls.Clear();

                foreach (OpenCvSharp.Rect r in rectList)
                {
                    Image image = pictureBox1.Image;
                    Bitmap bitmap = new Bitmap(image);
                    Bitmap croppedBitmap = bitmap.Clone(new Rectangle(r.X, r.Y, r.Width, r.Height), bitmap.PixelFormat);

                    double bestSimilarity = 0;

                    int bestIndex = 0;
                    Mat bestImage = new Mat(), bestCropped = new Mat(), bestMask = new Mat();

                    for (int i = 0; i < maskFiles.Length; i++)
                    {
                        // Загружаем изображение и маску
                        Mat img = new Mat();
                        Mat cropped = new Mat();
                        Mat mask = Cv2.ImRead(maskFiles[i]);
                        Mat templateAngle = Cv2.ImRead(templateFiles[i]);

                        Cv2.Resize(templateAngle, templateAngle, new OpenCvSharp.Size(mask.Size().Width, mask.Size().Height));
                        Cv2.Resize(BitmapConverter.ToMat(croppedBitmap), img, new OpenCvSharp.Size(mask.Size().Width, mask.Size().Height));
                        Cv2.Resize(BitmapConverter.ToMat(croppedBitmap), cropped, new OpenCvSharp.Size(mask.Size().Width, mask.Size().Height));

                        // Преобразуем изображение в оттенки серого
                        // Это позволит работать с одноканальным изображением, где значения пикселей представляют яркость
                        Cv2.CvtColor(img, img, ColorConversionCodes.BGR2GRAY);
                        Cv2.CvtColor(mask, mask, ColorConversionCodes.BGR2GRAY);
                        Cv2.CvtColor(templateAngle, templateAngle, ColorConversionCodes.BGR2GRAY);

                        // Бинаризация изображения
                        int thresholdValue = 127; // Пороговое значение
                        int maxValue = 255; // Максимальное значение для белых пикселей
                        Cv2.Threshold(img, img, thresholdValue, maxValue, ThresholdTypes.BinaryInv);
                        Cv2.Threshold(mask, mask, thresholdValue, maxValue, ThresholdTypes.Binary);
                        Cv2.Threshold(templateAngle, templateAngle, thresholdValue, maxValue, ThresholdTypes.Binary);

                        Cv2.BitwiseAnd(mask, templateAngle, mask);
                        Cv2.BitwiseAnd(img, templateAngle, img);

                        double sumWhitePixelsImage = (double)Cv2.CountNonZero(img);
                        double sumWhitePixelsMask = (double)Cv2.CountNonZero(mask);

                        double similarity = sumWhitePixelsImage / sumWhitePixelsMask * 100;

                        if (similarity > bestSimilarity && similarity < 100)
                        {
                            bestSimilarity = similarity;
                            bestIndex = i;
                            bestImage = img;
                            bestCropped = cropped;
                            bestMask = mask;
                        }
                    }

                    if ((int)bestSimilarity > numericProc.Value && (int)bestSimilarity < 100)
                    {
                        bestCropped.PutText($"{signName[bestIndex]} {(int)bestSimilarity}%", new OpenCvSharp.Point(10, 30), HersheyFonts.HersheyComplex, 0.5, new Scalar(0, 0, 0, 255), 1);
                        PictureBox picture = new PictureBox();
                        picture.Size = new System.Drawing.Size(150, 150);
                        picture.SizeMode = PictureBoxSizeMode.StretchImage;
                        flowLayoutPanel1.Controls.Add(picture);
                        picture.Image = BitmapConverter.ToBitmap(bestCropped);
                        tagCount++;

                        PictureBox picture2 = new PictureBox();
                        picture2.Size = new System.Drawing.Size(150, 150);
                        picture2.SizeMode = PictureBoxSizeMode.StretchImage;
                        flowLayoutPanel1.Controls.Add(picture2);
                        picture2.Image = BitmapConverter.ToBitmap(bestImage);
                        tagCount++;

                        PictureBox picture3 = new PictureBox();
                        picture3.Size = new System.Drawing.Size(150, 150);
                        picture3.SizeMode = PictureBoxSizeMode.StretchImage;
                        flowLayoutPanel1.Controls.Add(picture3);
                        picture3.Image = BitmapConverter.ToBitmap(SetFilter(bestMask));
                        tagCount++;
                    }
                }
            }
        }
    }
}
