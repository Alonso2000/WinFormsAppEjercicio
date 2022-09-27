namespace WinFormsAppEjercicio
{
    partial class frmCombo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDropDown = new System.Windows.Forms.ComboBox();
            this.cbDDL = new System.Windows.Forms.ComboBox();
            this.cbSimple = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtAnadir = new System.Windows.Forms.TextBox();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estilo DropDown";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(330, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estilo DropDownList";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(619, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estilo Simple";
            // 
            // cbDropDown
            // 
            this.cbDropDown.FormattingEnabled = true;
            this.cbDropDown.Items.AddRange(new object[] {
            "Azul",
            "Negro",
            "Rojo",
            "Verde"});
            this.cbDropDown.Location = new System.Drawing.Point(64, 91);
            this.cbDropDown.Name = "cbDropDown";
            this.cbDropDown.Size = new System.Drawing.Size(121, 23);
            this.cbDropDown.TabIndex = 3;
            this.cbDropDown.SelectedIndexChanged += new System.EventHandler(this.cbDropDown_SelectedIndexChanged);
            // 
            // cbDDL
            // 
            this.cbDDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDDL.FormattingEnabled = true;
            this.cbDDL.Items.AddRange(new object[] {
            "Azul",
            "Negro",
            "Rojo",
            "Verde"});
            this.cbDDL.Location = new System.Drawing.Point(328, 91);
            this.cbDDL.Name = "cbDDL";
            this.cbDDL.Size = new System.Drawing.Size(121, 23);
            this.cbDDL.TabIndex = 4;
            this.cbDDL.SelectedIndexChanged += new System.EventHandler(this.cbDropDownList_SelectedIndexChanged);
            // 
            // cbSimple
            // 
            this.cbSimple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbSimple.FormattingEnabled = true;
            this.cbSimple.Items.AddRange(new object[] {
            "Azul",
            "Negro",
            "Rojo",
            "Verde"});
            this.cbSimple.Location = new System.Drawing.Point(600, 91);
            this.cbSimple.Name = "cbSimple";
            this.cbSimple.Size = new System.Drawing.Size(121, 150);
            this.cbSimple.TabIndex = 5;
            this.cbSimple.SelectedIndexChanged += new System.EventHandler(this.cbSimple_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(64, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Muestra el ultimo color elegido:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(268, 223);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(181, 23);
            this.txtResultado.TabIndex = 7;
            // 
            // txtAnadir
            // 
            this.txtAnadir.Location = new System.Drawing.Point(64, 288);
            this.txtAnadir.Name = "txtAnadir";
            this.txtAnadir.Size = new System.Drawing.Size(181, 23);
            this.txtAnadir.TabIndex = 8;
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(283, 288);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(193, 23);
            this.btnAnadir.TabIndex = 9;
            this.btnAnadir.Text = "Añadir al dropdownlist";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // frmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.txtAnadir);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSimple);
            this.Controls.Add(this.cbDDL);
            this.Controls.Add(this.cbDropDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCombo";
            this.Text = "ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbDropDown;
        private ComboBox cbDDL;
        private ComboBox cbSimple;
        private Label label4;
        private TextBox txtResultado;
        private TextBox txtAnadir;
        private Button btnAnadir;
    }
}