using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppEjercicio
{
    public partial class frmCalendario : Form
    {
        public frmCalendario()
        {
            InitializeComponent();
        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {
            txtResultado.Text = dtp2.Value.ToString("dd/MM/yyyy");
            mc1.SelectionStart = this.dtp2.Value;
        }

        private void mc1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtResultado.Text = this.mc1.SelectionStart.ToString("dd/MM/yyyy");
            this.dtp2.Value = mc1.SelectionStart;
        }
    }
}
