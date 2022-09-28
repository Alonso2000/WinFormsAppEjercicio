namespace WinFormsAppEjercicio
{
    partial class frmTimer
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
            this.components = new System.ComponentModel.Container();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSegundos = new System.Windows.Forms.NumericUpDown();
            this.lbHora = new System.Windows.Forms.Label();
            this.tm1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.tm2 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSegundos)).BeginInit();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(265, 44);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(210, 23);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(265, 138);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(210, 23);
            this.txt2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(144, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Indica el intervalo, en segundos que quieres que cambie la palabra de un cuadro a" +
    " otro:";
            // 
            // nudSegundos
            // 
            this.nudSegundos.Location = new System.Drawing.Point(265, 275);
            this.nudSegundos.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSegundos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSegundos.Name = "nudSegundos";
            this.nudSegundos.Size = new System.Drawing.Size(210, 23);
            this.nudSegundos.TabIndex = 3;
            this.nudSegundos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHora.Location = new System.Drawing.Point(144, 327);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(65, 25);
            this.lbHora.TabIndex = 4;
            this.lbHora.Text = "label2";
            this.lbHora.Click += new System.EventHandler(this.lbHora_Click);
            // 
            // tm1
            // 
            this.tm1.Enabled = true;
            this.tm1.Interval = 1;
            this.tm1.Tick += new System.EventHandler(this.tm1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Image = global::WinFormsAppEjercicio.Properties.Resources.Captura;
            this.btnStart.Location = new System.Drawing.Point(26, 363);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 63);
            this.btnStart.TabIndex = 5;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tm2
            // 
            this.tm2.Interval = 1000;
            this.tm2.Tick += new System.EventHandler(this.tm2_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Image = global::WinFormsAppEjercicio.Properties.Resources.Captura2;
            this.btnStop.Location = new System.Drawing.Point(701, 363);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 63);
            this.btnStop.TabIndex = 6;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // frmTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.nudSegundos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTimer";
            this.Text = "Timer";
            ((System.ComponentModel.ISupportInitialize)(this.nudSegundos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt1;
        private TextBox txt2;
        private Label label1;
        private NumericUpDown nudSegundos;
        private Label lbHora;
        private System.Windows.Forms.Timer tm1;
        private Button btnStart;
        private System.Windows.Forms.Timer tm2;
        private Button btnStop;
    }
}