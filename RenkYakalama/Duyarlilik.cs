using System;
using System.Windows.Forms;

namespace RenkYakalama
{
    public partial class Duyarlilik : Form
    {
        public Duyarlilik()
        {
            InitializeComponent();
            numericUpDownRed.Value = ColorDefine.redSensistivty;
            numericUpDownGreen.Value = ColorDefine.greenSensitivty;
            numericUpDownBlue.Value = ColorDefine.blueSensitivty;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            ColorDefine.setSensitivity(
                System.Convert.ToByte(numericUpDownRed.Value),
                System.Convert.ToByte(numericUpDownGreen.Value),
                System.Convert.ToByte(numericUpDownBlue.Value)
                );
            Close();
        }
    }
}
