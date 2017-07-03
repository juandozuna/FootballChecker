namespace JuegoFutbol
{
    partial class FALTA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FALTA));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEquipoInfractor = new System.Windows.Forms.ComboBox();
            this.comboBoxEquipoVictima = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxJugadoresInfractor = new System.Windows.Forms.ComboBox();
            this.comboBoxJugadoresVictima = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxTipoFalta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // comboBoxEquipoInfractor
            // 
            this.comboBoxEquipoInfractor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEquipoInfractor.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxEquipoInfractor, "comboBoxEquipoInfractor");
            this.comboBoxEquipoInfractor.Name = "comboBoxEquipoInfractor";
            this.comboBoxEquipoInfractor.SelectedIndexChanged += new System.EventHandler(this.comboBoxEquipoInfractor_SelectedIndexChanged);
            // 
            // comboBoxEquipoVictima
            // 
            this.comboBoxEquipoVictima.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEquipoVictima.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxEquipoVictima, "comboBoxEquipoVictima");
            this.comboBoxEquipoVictima.Name = "comboBoxEquipoVictima";
            this.comboBoxEquipoVictima.SelectedIndexChanged += new System.EventHandler(this.comboBoxEquipoVictima_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // comboBoxJugadoresInfractor
            // 
            this.comboBoxJugadoresInfractor.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxJugadoresInfractor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJugadoresInfractor.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxJugadoresInfractor, "comboBoxJugadoresInfractor");
            this.comboBoxJugadoresInfractor.Name = "comboBoxJugadoresInfractor";
            this.comboBoxJugadoresInfractor.SelectedIndexChanged += new System.EventHandler(this.comboBoxJugadoresInfractor_SelectedIndexChanged);
            // 
            // comboBoxJugadoresVictima
            // 
            this.comboBoxJugadoresVictima.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxJugadoresVictima.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJugadoresVictima.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxJugadoresVictima, "comboBoxJugadoresVictima");
            this.comboBoxJugadoresVictima.Name = "comboBoxJugadoresVictima";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxTipoFalta
            // 
            this.comboBoxTipoFalta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoFalta.FormattingEnabled = true;
            this.comboBoxTipoFalta.Items.AddRange(new object[] {
            resources.GetString("comboBoxTipoFalta.Items"),
            resources.GetString("comboBoxTipoFalta.Items1"),
            resources.GetString("comboBoxTipoFalta.Items2"),
            resources.GetString("comboBoxTipoFalta.Items3"),
            resources.GetString("comboBoxTipoFalta.Items4")});
            resources.ApplyResources(this.comboBoxTipoFalta, "comboBoxTipoFalta");
            this.comboBoxTipoFalta.Name = "comboBoxTipoFalta";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // FALTA
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxTipoFalta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxJugadoresVictima);
            this.Controls.Add(this.comboBoxJugadoresInfractor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxEquipoVictima);
            this.Controls.Add(this.comboBoxEquipoInfractor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FALTA";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FALTA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEquipoInfractor;
        private System.Windows.Forms.ComboBox comboBoxEquipoVictima;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxJugadoresInfractor;
        private System.Windows.Forms.ComboBox comboBoxJugadoresVictima;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxTipoFalta;
        private System.Windows.Forms.Label label5;
    }
}