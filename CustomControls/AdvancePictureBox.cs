using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;

namespace CustomControls
{
    public partial class AdvancePictureBox : UserControl
    {
        public string openedfile { get; set; }
        public string tempfile { get; set; }

        private FilterInfoCollection VideoCaptureDevices;
        private static VideoCaptureDevice FinalVideo;
        public Bitmap _latestFrame;

        int state = -1;
        public static string MonkierString;

        public string imagepath;

        public void setPath(string imgpath)
        {
            pictureBox.Image = Image.FromFile(imgpath);
            imagepath = imgpath;
        }

        public void save(string path, System.Drawing.Imaging.ImageFormat f)
        {
            if (pictureBox.Image == null)
            {
                throw new Exception("No Image Taken Or Selected");
            }
            pictureBox.Image.Save(path, f);
            imagepath = path;

        }

        public AdvancePictureBox()
        {
            InitializeComponent();
            VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        }

        private void AdvancePictureBox_Paint(object sender, PaintEventArgs e)
        {

            this.Height = this.Width + 50;
            pictureBox.Height = pictureBox.Width;
        }

        private void materialButtonfile_Click(object sender, EventArgs e)
        {
            var op = new OpenFileDialog();
            op.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (op.ShowDialog() == DialogResult.OK)
            {
                openedfile = op.FileName;
                tempfile = openedfile;
                try
                {
                    pictureBox.Image = Image.FromFile(openedfile);
                }
                catch (Exception)
                {

                    Notify.show("Cannot Load Image File", 3);
                }
            }
        }

        private void materialButtoncamera_Click(object sender, EventArgs e)
        {
            try
            {
                if (state == 1)
                {
                    FinalVideo.SignalToStop();
                    FinalVideo.WaitForStop();
                    state = 0;
                    materialButtoncamera.BackgroundImage = Properties.Resources.camera_1;
                }
                else
                {
                    if (FinalVideo == null)
                    {
                        FinalVideo = new VideoCaptureDevice(VideoCaptureDevices[0].MonikerString);
                    }
                    if (state == -1)
                    {
                        FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
                    }
                    FinalVideo.Start();
                    state = 1;
                    materialButtoncamera.BackgroundImage = Properties.Resources.camera_settings_focus;
                }
            }
            catch (Exception ex)
            {
                Notify.show(ex.Message, 3);
            }
        }

        private void FinalVideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            try
            {
            Bitmap video = (Bitmap)eventArgs.Frame.Clone();
            pictureBox.Invoke((MethodInvoker)delegate
            {
                pictureBox.Image = video;
            });

            }
            catch (Exception)
            {

                
            }

        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButtonreset_Click(object sender, EventArgs e)
        {
            this.pictureBox.Image = null;
            this.imagepath = "";
        }
    }
}
