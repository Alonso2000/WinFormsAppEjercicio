using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WinFormsAppEjercicio
{
    public partial class frmTimer : Form
    {
        public frmTimer()
        {
            InitializeComponent();
            lbHora.Text = DateTime.Now.ToString("h:mm:ss:f");
            btnStop.Hide();
        }

        private void lbHora_Click(object sender, EventArgs e)
        {

        }

        private void tm1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString("h:mm:ss:ff");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(txt1.Text != "" || txt2.Text != "")
            {
                txt1.ReadOnly = true;
                txt2.ReadOnly = true;
                TimeSpan a = new TimeSpan(0,0, (int)nudSegundos.Value);
                tm2.Interval = (int)a.TotalMilliseconds;
                tm2.Enabled = true;
                btnStart.Hide();
                btnStop.Show();
            }
            else
            {
                MessageBox.Show("Rellena un campo");
            }
        }

        private void tm2_Tick(object sender, EventArgs e)
        {
            if(txt1.Text != "")
            {
                txt2.Text = txt1.Text;
                txt1.Text = "";
            }
            else
            {
                txt1.Text = txt2.Text;
                txt2.Text = "";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tm2.Enabled = false;
            btnStop.Hide();
            btnStart.Show();
        }
    }
}
