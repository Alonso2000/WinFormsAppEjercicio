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
            this.btnCuadro = new System.Windows.Forms.Button();
            this.btnRadio = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnCombo = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnTriangulos = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBotones.Controls.Add(this.btnTimer);
            this.pnlBotones.Controls.Add(this.btnCuadro);
            this.pnlBotones.Controls.Add(this.btnRadio);
            this.pnlBotones.Controls.Add(this.btnCalendar);
            this.pnlBotones.Controls.Add(this.btnCombo);
            this.pnlBotones.Controls.Add(this.btnColor);
            this.pnlBotones.Controls.Add(this.btnTriangulos);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(200, 513);
            this.pnlBotones.TabIndex = 0;
            // 
            // btnCuadro
            // 
            this.btnCuadro.Location = new System.Drawing.Point(49, 373);
            this.btnCuadro.Name = "btnCuadro";
            this.btnCuadro.Size = new System.Drawing.Size(98, 45);
            this.btnCuadro.TabIndex = 5;
            this.btnCuadro.Text = "Cuadro de texto";
            this.btnCuadro.UseVisualStyleBackColor = true;
            this.btnCuadro.Click += new System.EventHandler(this.btnCuadro_Click);
            // 
            // btnRadio
            // 
            this.btnRadio.Location = new System.Drawing.Point(49, 299);
            this.btnRadio.Name = "btnRadio";
            this.btnRadio.Size = new System.Drawing.Size(98, 45);
            this.btnRadio.TabIndex = 4;
            this.btnRadio.Text = "Radio";
            this.btnRadio.UseVisualStyleBackColor = true;
            this.btnRadio.Click += new System.EventHandler(this.btnRadio_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.Location = new System.Drawing.Point(49, 234);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(98, 45);
            this.btnCalendar.TabIndex = 3;
            this.btnCalendar.Text = "Calendario";
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnCombo
            // 
            this.btnCombo.Location = new System.Drawing.Point(49, 158);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(98, 45);
            this.btnCombo.TabIndex = 2;
            this.btnCombo.Text = "Combo Box";
            this.btnCombo.UseVisualStyleBackColor = true;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(49, 88);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(98, 45);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Colores";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
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
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(49, 441);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(98, 45);
            this.btnTimer.TabIndex = 6;
            this.btnTimer.Text = "Timer";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 513);
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
        private Button btnColor;
        private Button btnCombo;
        private Button btnCalendar;
        private Button btnRadio;
        private Button btnCuadro;
        private Button btnTimer;
    }
}