using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;



namespace GUI_QLSV
{
    public partial class frmWebCam : Form
    {
        VideoCaptureDevice frame;
        FilterInfoCollection Devices;
        string output;
        public frmWebCam()
        {
            InitializeComponent();
            btnTakePhoto.Visible = false;
            btnStop.Visible = false;
        }
        void Start_cam()
        {
            Devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            frame = new VideoCaptureDevice(Devices[0].MonikerString);
            frame.NewFrame += Frame_NewFrame;
            frame.Start();

        }

        private void Frame_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            try
            {
                ptxWebCam.Image = (Image)eventArgs.Frame.Clone();
            }
            catch (Exception ex) { }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Start_cam();
            btnTakePhoto.Visible = true;
            btnStop.Visible = true;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            frame.Stop();
            ptxWebCam.Image = null;
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtSave.Text = folderBrowserDialog1.SelectedPath;
            output = folderBrowserDialog1.SelectedPath;
            if (output != null) btnTakePhoto.Enabled = true;
        }

        private void btnTakePhoto_Click(object sender, EventArgs e)
        {
            if (output != "" && ptxWebCam.Image != null)
            {
                ptxWebCam.Image.Save(output + "\\Image.png");
                MessageBox.Show("Lưu Thành Công", "OK");
            }
            btnTakePhoto.Visible = false;
            btnStop.Visible = false;
        }

        private void WebCam_Closed(object sender, FormClosedEventArgs e)
        {

            frame.Stop();
            ptxWebCam.Image = null;
        }
    }
}
