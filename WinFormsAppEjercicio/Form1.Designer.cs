namespace WinFormsAppEjercicio
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnTriangulos = new System.Windows.Forms.Button();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBotones.Controls.Add(this.btnTriangulos);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(200, 450);
            this.pnlBotones.TabIndex = 0;
            // 
            // btnTriangulos
            // 
            this.btnTriangulos.Location = new System.Drawing.Point(49, 12);
            this.btnTriangulos.Name = "btnTriangulos";
            this.btnTriangulos.Size = new System.Drawing.Size(98, 45);
            this.btnTriangulos.TabIndex = 0;
            this.btnTriangulos.Text = "Triangulos";
            this.btnTriangulos.UseVisualStyleBackColor = true;
            this.btnTriangulos.Click += new System.EventHandler(this.btnTriangulos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlBotones;
        private Button btnTriangulos;
    }
}