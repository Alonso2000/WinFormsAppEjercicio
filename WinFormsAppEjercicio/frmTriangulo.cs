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
    public partial class frmTriangulo : Form
    {
        public frmTriangulo()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            int i;
            lbResultado.Text = "";
            if(txtA.Text.Length == 0 || txtB.Text.Length == 0 || txtC.Text.Length == 0)
            {
                MessageBox.Show("Rellena todos los campos");
            }
            else if(!Int32.TryParse(txtA.Text, out i) || (!Int32.TryParse(txtB.Text, out i) || (!Int32.TryParse(txtC.Text, out i))))
            {
                MessageBox.Show("Solo numeros");
            }
            else
            {
                if(txtA.Text == txtB.Text && txtA.Text == txtC.Text && txtB.Text == txtC.Text)
                {
                    lbResultado.Text = "Es un triangulo equilatero";
                }
            }
        }
    }
}
