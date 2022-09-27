namespace WinFormsAppEjercicio
{
    partial class frmRadio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbVerde = new System.Windows.Forms.RadioButton();
            this.rbAzul = new System.Windows.Forms.RadioButton();
            this.rbRojo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chbCentrado = new System.Windows.Forms.CheckBox();
            this.chbMayusculas = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(215, 32);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(355, 23);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "probando...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.rbVerde);
            this.panel1.Controls.Add(this.rbAzul);
            this.panel1.Controls.Add(this.rbRojo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(42, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 299);
            this.panel1.TabIndex = 1;
            // 
            // rbVerde
            // 
            this.rbVerde.AutoSize = true;
            this.rbVerde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbVerde.Location = new System.Drawing.Point(20, 236);
            this.rbVerde.Name = "rbVerde";
            this.rbVerde.Size = new System.Drawing.Size(58, 19);
            this.rbVerde.TabIndex = 3;
            this.rbVerde.TabStop = true;
            this.rbVerde.Text = "Verde";
            this.rbVerde.UseVisualStyleBackColor = true;
            this.rbVerde.CheckedChanged += new System.EventHandler(this.rbVerde_CheckedChanged);
            // 
            // rbAzul
            // 
            this.rbAzul.AutoSize = true;
            this.rbAzul.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbAzul.Location = new System.Drawing.Point(20, 130);
            this.rbAzul.Name = "rbAzul";
            this.rbAzul.Size = new System.Drawing.Size(49, 19);
            this.rbAzul.TabIndex = 2;
            this.rbAzul.TabStop = true;
            this.rbAzul.Text = "Azul";
            this.rbAzul.UseVisualStyleBackColor = true;
            this.rbAzul.CheckedChanged += new System.EventHandler(this.rbAzul_CheckedChanged);
            // 
            // rbRojo
            // 
            this.rbRojo.AutoSize = true;
            this.rbRojo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbRojo.Location = new System.Drawing.Point(20, 40);
            this.rbRojo.Name = "rbRojo";
            this.rbRojo.Size = new System.Drawing.Size(50, 19);
            this.rbRojo.TabIndex = 1;
            this.rbRojo.TabStop = true;
            this.rbRojo.Text = "Rojo";
            this.rbRojo.UseVisualStyleBackColor = true;
            this.rbRojo.CheckedChanged += new System.EventHandler(this.rbRojo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Colores";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Peru;
            this.panel2.Controls.Add(this.chbCentrado);
            this.panel2.Controls.Add(this.chbMayusculas);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(445, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 299);
            this.panel2.TabIndex = 2;
            // 
            // chbCentrado
            // 
            this.chbCentrado.AutoSize = true;
            this.chbCentrado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbCentrado.Location = new System.Drawing.Point(22, 218);
            this.chbCentrado.Name = "chbCentrado";
            this.chbCentrado.Size = new System.Drawing.Size(77, 19);
            this.chbCentrado.TabIndex = 2;
            this.chbCentrado.Text = "Centrado";
            this.chbCentrado.UseVisualStyleBackColor = true;
            this.chbCentrado.CheckedChanged += new System.EventHandler(this.chbCentrado_CheckedChanged);
            // 
            // chbMayusculas
            // 
            this.chbMayusculas.AutoSize = true;
            this.chbMayusculas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbMayusculas.Location = new System.Drawing.Point(22, 85);
            this.chbMayusculas.Name = "chbMayusculas";
            this.chbMayusculas.Size = new System.Drawing.Size(104, 19);
            this.chbMayusculas.TabIndex = 1;
            this.chbMayusculas.Text = "En mayusculas";
            this.chbMayusculas.UseVisualStyleBackColor = true;
            this.chbMayusculas.CheckedChanged += new System.EventHandler(this.chbMayusculas_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(5, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Formato";
            // 
            // frmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRadio";
            this.Text = "frmRadio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtResultado;
        private Panel panel1;
        private RadioButton rbVerde;
        private RadioButton rbAzul;
        private RadioButton rbRojo;
        private Label label1;
        private Panel panel2;
        private CheckBox chbCentrado;
        private CheckBox chbMayusculas;
        private Label label2;
    }
}