using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppEjercicio
{
    public partial class frmColor : Form
    {
        public frmColor()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog a = new ColorDialog();
            if (a.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = a.Color;
            }
        }

        private void btnLetra_Click(object sender, EventArgs e)
        {
            FontDialog a = new FontDialog();
            a.ShowColor = true;
            if (a.ShowDialog() == DialogResult.OK )
            {
                txtResultado.Font = a.Font;
                txtResultado.ForeColor = a.Color;
            }
        }
    }
}
