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
    public partial class frmCombo : Form
    {
        public frmCombo()
        {
            InitializeComponent();
        }

        private void cbDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtResultado.Text = cbDDL.Text;
        }

        private void cbDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtResultado.Text = cbDropDown.Text;
        }

        private void cbSimple_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtResultado.Text = cbSimple.Text;
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            cbDDL.Items.Add(txtAnadir.Text);
            txtAnadir.Clear();
        }
    }
}
