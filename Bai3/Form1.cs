using System;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYourFavHobb_Click(object sender, EventArgs e)
        {
            string str = "";
            foreach (Control control in groupBox1.Controls)
            {
                if (((CheckBox)control).Checked)
                {
                    str += "\n" + control.Text;
                }   
            }
            MessageBox.Show("Sở thích của bạn là: " + str);
        }

        private void btnYourFavColor_Click(object sender, EventArgs e)
        {
            string str = "";
            foreach (Control control in groupBox2.Controls)
            {
                if (((RadioButton)control).Checked)
                {
                    str += "\n" + control.Text;
                }
            }
            MessageBox.Show("Màu bạn thích là: " + str);
        }
    }
}
