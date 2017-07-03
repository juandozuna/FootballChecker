namespace JuegoFutbol
{
    partial class RedCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedCard));
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxEQUIPO = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxJUGA = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(81, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 60);
            this.label5.TabIndex = 0;
            this.label5.Text = "TARJETA ROJA";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Juego brusco grave (falta violenta).",
            "Conducta violenta (cualquier otro acto de violencia).",
            "Escupir a un adversario, árbitro, dirigente o cualquier otra persona situada en l" +
                "as instalaciones del encuentro.",
            "Manipulación de ofensa deliberada de negar una oportunidad de gol a cualquier jug" +
                "ador.",
            "Cometer una falta que niegue a un adversario una oportunidad de gol.",
            "Usar lenguaje ofensivo, insultante o abusivo, o gestos.",
            "Celebrar un gol de manera obscena."});
            this.comboBox2.Location = new System.Drawing.Point(74, 128);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(302, 28);
            this.comboBox2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(148, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 42);
            this.label6.TabIndex = 2;
            this.label6.Text = "RAZON";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(148, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 42);
            this.label7.TabIndex = 3;
            this.label7.Text = "EQUIPO";
            // 
            // comboBoxEQUIPO
            // 
            this.comboBoxEQUIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEQUIPO.DropDownWidth = 600;
            this.comboBoxEQUIPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.75F, System.Drawing.FontStyle.Bold);
            this.comboBoxEQUIPO.FormattingEnabled = true;
            this.comboBoxEQUIPO.Location = new System.Drawing.Point(74, 210);
            this.comboBoxEQUIPO.Name = "comboBoxEQUIPO";
            this.comboBoxEQUIPO.Size = new System.Drawing.Size(302, 34);
            this.comboBoxEQUIPO.TabIndex = 4;
            this.comboBoxEQUIPO.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(127, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 42);
            this.label8.TabIndex = 5;
            this.label8.Text = "JUGADOR";
            // 
            // comboBoxJUGA
            // 
            this.comboBoxJUGA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJUGA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.75F, System.Drawing.FontStyle.Bold);
            this.comboBoxJUGA.FormattingEnabled = true;
            this.comboBoxJUGA.Location = new System.Drawing.Point(75, 292);
            this.comboBoxJUGA.Name = "comboBoxJUGA";
            this.comboBoxJUGA.Size = new System.Drawing.Size(302, 34);
            this.comboBoxJUGA.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(87, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "INGRESAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RedCard
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(455, 393);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxJUGA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxEQUIPO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RedCard";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.YellowCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxEquipos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxJugadores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxEQUIPO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxJUGA;
        private System.Windows.Forms.Button button2;
    }
}
     