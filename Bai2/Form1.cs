using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResult.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txtNum1.Text) + Convert.ToInt32(txtNum2.Text);
            txtResult.Text = result.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txtNum1.Text) - Convert.ToInt32(txtNum2.Text);
            txtResult.Text = result.ToString();
        }

        private void btnMutiply_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txtNum1.Text) * Convert.ToInt32(txtNum2.Text);
            txtResult.Text = result.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(txtNum1.Text) / Convert.ToDouble(txtNum2.Text);
            txtResult.Text = result.ToString();
        }

        private void txtNum1_Keypress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)){
                e.Handled = true;
            }
        }

        private void txtNum2_Keypress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }
    }
}
