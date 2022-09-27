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

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "frmColor")
                {
                    this.MdiChildren[0].Close();

                    frmColor t = new frmColor();
                    t.MdiParent = this;
                    t.Dock = DockStyle.Fill;
                    t.Show();
                }

            }
            else
            {
                frmColor t = new frmColor();
                t.MdiParent = this;
                t.Dock = DockStyle.Fill;
                t.Show();
            }
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "frmCombo")
                {
                    this.MdiChildren[0].Close();

                    frmCombo t = new frmCombo();
                    t.MdiParent = this;
                    t.Dock = DockStyle.Fill;
                    t.Show();
                }

            }
            else
            {
                frmCombo t = new frmCombo();
                t.MdiParent = this;
                t.Dock = DockStyle.Fill;
                t.Show();
            }
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "frmCalendario")
                {
                    this.MdiChildren[0].Close();

                    frmCalendario t = new frmCalendario();
                    t.MdiParent = this;
                    t.Dock = DockStyle.Fill;
                    t.Show();
                }

            }
            else
            {
                frmCalendario t = new frmCalendario();
                t.MdiParent = this;
                t.Dock = DockStyle.Fill;
                t.Show();
            }
        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "frmRadio")
                {
                    this.MdiChildren[0].Close();

                    frmRadio t = new frmRadio();
                    t.MdiParent = this;
                    t.Dock = DockStyle.Fill;
                    t.Show();
                }

            }
            else
            {
                frmRadio t = new frmRadio();
                t.MdiParent = this;
                t.Dock = DockStyle.Fill;
                t.Show();
            }
        }
    }
}