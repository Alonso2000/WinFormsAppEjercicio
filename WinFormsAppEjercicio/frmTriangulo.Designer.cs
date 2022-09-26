namespace WinFormsAppEjercicio
{
    partial class frmTriangulo
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
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbC = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbA.Location = new System.Drawing.Point(78, 41);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(78, 18);
            this.lbA.TabIndex = 0;
            this.lbA.Text = "LADO A:";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbB.Location = new System.Drawing.Point(78, 112);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(78, 18);
            this.lbB.TabIndex = 1;
            this.lbB.Text = "LADO B:";
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbC.Location = new System.Drawing.Point(78, 185);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(77, 18);
            this.lbC.TabIndex = 2;
            this.lbC.Text = "LADO C:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(226, 41);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(169, 23);
            this.txtA.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(226, 107);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(169, 23);
            this.txtB.TabIndex = 4;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(226, 185);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(169, 23);
            this.txtC.TabIndex = 5;
            // 
            // btnResultado
            // 
            this.btnResultado.BackColor = System.Drawing.Color.Red;
            this.btnResultado.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResultado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnResultado.Location = new System.Drawing.Point(78, 251);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(592, 32);
            this.btnResultado.TabIndex = 6;
            this.btnResultado.Text = "Sera un Triangulo??";
            this.btnResultado.UseVisualStyleBackColor = false;
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(326, 330);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(0, 15);
            this.lbResultado.TabIndex = 7;
            // 
            // frmTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTriangulo";
            this.Text = "Triangulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbA;
        private Label lbB;
        private Label lbC;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private Button btnResultado;
        private Label lbResultado;
    }
}