using System;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Phòng", 100);
            listView1.Columns.Add("Số lượng", 100);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtRoomName.Text)) || (string.IsNullOrEmpty(txtAmount.Text)))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
                return;
            }
            ListViewItem item = new ListViewItem();
            item.Text = txtRoomName.Text;
            ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, (txtAmount.Text));
            item.SubItems.Add(subitem);
            listView1.Items.Add(item);
            txtRoomName.Clear();
            txtAmount.Clear();
            txtRoomName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult dl = MessageBox.Show("Bạn muốn xóa", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dl == DialogResult.OK)
                    listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else MessageBox.Show("Xóa lỗi");
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
