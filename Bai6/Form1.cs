using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Bai6
{
    public partial class Form1 : Form
    {
        Timer timer1;
        Timer timer2;
        public Form1()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);

            timer2 = new Timer();
            timer2.Interval = 10;
            timer2.Tick += new EventHandler(timer2_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());
            lbHour.Text = String.Format("{0:hh:mm:ss tt}", dt);
            lbDate.Text = String.Format("{0:dd/MM/yyyy}", dt);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            progressBar1.Increment(1);
            lbCompleted.Text = "Connecting to from " + progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer2.Enabled = false;
                frm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Enabled == true)
            {
                progressBar1.Enabled = false;
                timer2.Start();
                timer1.Start();
            }
            else
            {
                progressBar1.Enabled = true;
                timer2.Stop();
                timer1.Stop();
            }
        }
    }
}
