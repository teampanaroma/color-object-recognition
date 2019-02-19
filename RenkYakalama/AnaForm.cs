using MCSystem;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RenkYakalama
{
    public partial class AnaForm : Form
    {
        private CameraDevice webcam;
        private Picture picture;
        private IntPtr scan0 = IntPtr.Zero;
        private Canvas canvas;
        private bool fullscreen = false;
        private Size defaultSize;

        public AnaForm()
        {
            
            InitializeComponent();
            initWebcam();
            this.defaultSize = new Size(this.Size.Width, this.Size.Height);
            if (webcam != null)
            {
                picture = new Picture(webcam.Width, webcam.Height);
                canvas = new Canvas(picture);
                initTimer();
            }
        }

        private void initWebcam()
        {
            KameraSecimi getCamera = new KameraSecimi();
            webcam = getCamera.getCamera();
            if (webcam is Camera && webcam != null)
            {
                PictureBox temp = new PictureBox();
                (webcam as Camera).VideoPreview.VideoControl = temp;

                webcam.Connect();
                kameraPictureBox.Width = webcam.Width;
                kameraPictureBox.Height = webcam.Height;
                webcam.Start();
                scan0 = Marshal.AllocCoTaskMem(webcam.DataLength);
            }
        }

        private void initTimer()
        {
            timer.Enabled = true;
        }

        private void tamEkranGoster()
        {
            if (fullscreen) 
            {
                this.Bounds = Screen.PrimaryScreen.Bounds;
                kameraPictureBox.Location = new Point(0, 24);
                kameraPictureBox.Size = new Size(webcam.Width, webcam.Height);
                this.menuStrip1.Show();
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(defaultSize.Width, defaultSize.Height);
                this.TopMost = false;

                fullscreen = false;
            }
            else 
            {
                Bounds = Screen.PrimaryScreen.Bounds;
                this.menuStrip1.Hide(); 
                this.FormBorderStyle = FormBorderStyle.None; 
                this.WindowState = FormWindowState.Maximized; 
                this.TopMost = true; 

                if (this.Size.Width > this.Size.Height) 
                {
                    double oran = (double)this.Size.Height / (double)webcam.Height;
                    int newScreen = Convert.ToInt32(webcam.Width * oran);
                    kameraPictureBox.Size = new Size(newScreen, this.Size.Height); 
                    kameraPictureBox.Location = new Point(this.Size.Width / 2 - newScreen / 2, 0); 
                }
                else
                {
                    double oran = (double)this.Size.Width / (double)webcam.Width;
                    int newScreen = Convert.ToInt32(webcam.Height * oran);
                    kameraPictureBox.Size = new Size(this.Size.Width, newScreen);
                    kameraPictureBox.Location = new Point(0, this.Size.Height / 2 - newScreen / 2);
                }

                fullscreen = true;
            }
        }

        private void RedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDefine.redRecognition();
        }

        private void GreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDefine.greenRecognition();
        }
        private void BlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDefine.blueRecognition();
        }

        private void CleanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.Clean();
        }
        private void ChangeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseColorBox.Color = canvas.getBrushColors(); 
            DialogResult v = ChooseColorBox.ShowDialog(); 
            if (v == DialogResult.OK)
            {
                canvas.setBrushColors(ChooseColorBox.Color);
            }
            // http://www.c-sharpcorner.com/UploadFile/mahesh/ColrDialogHowtouse12012005001424AM/ColrDialogHowtouse.aspx
        }

        private void kameraPictureBox_DoubleClick(object sender, EventArgs e)
        {
            tamEkranGoster();
        }

        private void AnaForm_DoubleClick(object sender, EventArgs e)
        {
            tamEkranGoster();
        }
        private void AnaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (webcam != null)
             webcam.Stop();
            if (scan0 != IntPtr.Zero)
            {
                Marshal.FreeCoTaskMem(scan0);
            } 
            scan0 = IntPtr.Zero;
            if (webcam != null)
             webcam.Disconnect();
            timer.Enabled = false;
        }

        private void RenkHassasiyetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Duyarlilik().ShowDialog(this);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;

            byte[] data = webcam.SnapshotByte();
            if (data == null)
                return;

            try
            {
                picture.updateImage(data);

                Marshal.Copy(data, 0, scan0, webcam.DataLength);
                if (scan0 == IntPtr.Zero) return;

                Bitmap build = new Bitmap(webcam.Width, webcam.Height, webcam.Stride, System.Drawing.Imaging.PixelFormat.Format24bppRgb, scan0);
                build.RotateFlip(RotateFlipType.RotateNoneFlipXY);

                Graphics g = Graphics.FromImage(build);
                canvas.render(g);
                g.Flush();

                kameraPictureBox.Image = build;
            }
            catch (Exception ex)
            {
                AnaForm_FormClosed(null, null);
                throw ex;
            }

            timer.Enabled = true;
        }
    }
}
