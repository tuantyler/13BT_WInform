using System;
using System.Windows.Forms;

namespace Bai10
{
    public partial class Form1 : Form
    {
        Timer timerTime;
        Timer timerDate;
        public Form1()
        {
            InitializeComponent();
            timerTime = new Timer();
            timerTime.Tick += timerTime_Tick;

            timerDate = new Timer();
            timerDate.Tick += timerDate_Tick;
        }

        private void hiểnThịThờiGianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerTime.Start();
        }

        private void hiểnThịNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerDate.Start();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());
            lblTime.Text = String.Format("{0:hh:mm:ss tt}", dt);
        }
        private void timerDate_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());
            lblDate.Text = String.Format("{0:dd/MM/yyyy}", dt);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
