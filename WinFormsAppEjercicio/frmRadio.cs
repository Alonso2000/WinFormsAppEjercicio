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
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }

        private void rbRojo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRojo.Checked)
            {
                txtResultado.ForeColor = Color.Red;
            }
        }

        private void rbAzul_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAzul.Checked)
            {
                txtResultado.ForeColor = Color.Blue;
            }
        }

        private void rbVerde_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVerde.Checked)
            {
                txtResultado.ForeColor = Color.Green;
            }
        }

        private void chbMayusculas_CheckedChanged(object sender, EventArgs e)
        {
            string copia;
            if (chbMayusculas.Checked)
            {
                copia = txtResultado.Text.ToUpper();
                txtResultado.Text = copia;
            }
            else
            {
                copia = txtResultado.Text.ToLower();
                txtResultado.Text = copia;
            }
        }

        private void chbCentrado_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCentrado.Checked)
            {
                txtResultado.TextAlign = HorizontalAlignment.Center;
            }
            else
            {
                txtResultado.TextAlign = HorizontalAlignment.Left;
            }
        }
    }
}
