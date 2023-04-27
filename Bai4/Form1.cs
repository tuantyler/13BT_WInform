using System;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnterInfo_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtName.Text);
            txtCountKhaiBao.Text = listBox1.Items.Count.ToString();
            txtName.Clear();
            txtName.Focus();
        }

        private void btnDeleteCurrentSelect_Click(object sender, EventArgs e)
        {
            try
            {
                int count = Convert.ToInt32(txtCountKhaiBao.Text);
                if (count != 0)
                {
                    listBox1.Items.Remove(listBox1.SelectedItems[0]);
                }
                txtCountKhaiBao.Text = (count - 1).ToString();
            }
            catch
            {
                MessageBox.Show("Bạn phải chọn đã!");
            }
        }

        private void btnDeleteFirst_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(txtCountKhaiBao.Text);
            if (count != 0)
            {
                listBox1.Items.RemoveAt(0);
            }
            txtCountKhaiBao.Text = (count - 1).ToString();
        }
    

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txtCountKhaiBao.Text = "0";
        }

        private void btnDeleteLast_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(txtCountKhaiBao.Text);
            if (count != 0)
            {
                listBox1.Items.RemoveAt(count - 1);
            }
            txtCountKhaiBao.Text = (count - 1).ToString();
        }
    }
}
