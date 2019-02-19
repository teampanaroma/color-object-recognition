using MCSystem;
using System;
using System.Windows.Forms;

namespace RenkYakalama
{
    public partial class KameraSecimi : Form
    {
        CameraDevice selectedCamera = null;
        CameraDevices camera = new CameraDevices(true);

        public KameraSecimi()
        {
            InitializeComponent();

            if (camera.Count == 1)
            {
                selectedCamera = new Camera(camera[0].Name);
                Close();
            }
            else if (camera.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("No webcam found.The application for your runnig requires a conencted webcam. Please plug in your webcam and run it again.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                listComboBox.Items.Clear();
                for (int i = 0; i < camera.Count; ++i)
                {
                    listComboBox.Items.Add(camera[i].Name);
                }
                listComboBox.SelectedIndex = 0;
                ShowDialog();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            selectedCamera = new Camera(listComboBox.Text);
            this.Close();
        }
        public CameraDevice getCamera()
        {
            return selectedCamera;
        }
        private void zrusitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void KameraSecimi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
    }
}
