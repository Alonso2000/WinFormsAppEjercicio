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
    public partial class frmCuadro : Form
    {
        public frmCuadro()
        {
            InitializeComponent();
        }

        private void btnFoco_Click(object sender, EventArgs e)
        {
            txtMusica.Focus();
        }

        private void btnEscritura_Click(object sender, EventArgs e)
        {
            if(txtNombre.ReadOnly == false)
            {
                txtNombre.ReadOnly = true;
            }
            else
            {
                txtNombre.ReadOnly = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtApellidos.Enabled == true)
            {
                txtApellidos.Enabled = false;
            }
            else
            {
                txtApellidos.Enabled = true;
            }
        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            if (txtContrasenia.UseSystemPasswordChar)
            {
                txtContrasenia.UseSystemPasswordChar = false;
            }
            else
            {
                txtContrasenia.UseSystemPasswordChar = true;
            }
        }
    }
}
