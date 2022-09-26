namespace WinFormsAppEjercicio
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnTriangulos_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "frmTriangulo")
                {
                    this.MdiChildren[0].Close();

                    frmTriangulo t = new frmTriangulo();
                    t.MdiParent = this;
                    t.Dock = DockStyle.Fill;
                    t.Show();
                }

            }
            else
            {
                frmTriangulo t = new frmTriangulo();
                t.MdiParent = this;
                t.Dock = DockStyle.Fill;
                t.Show();
            }
        }
    }
}