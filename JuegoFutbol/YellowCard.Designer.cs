namespace JuegoFutbol
{
    partial class YellowCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YellowCard));
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxJUGA = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxEQUIPO = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(82, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 44);
            this.button2.TabIndex = 15;
            this.button2.Text = "INGRESAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxJUGA
            // 
            this.comboBoxJUGA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJUGA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.75F, System.Drawing.FontStyle.Bold);
            this.comboBoxJUGA.FormattingEnabled = true;
            this.comboBoxJUGA.Location = new System.Drawing.Point(60, 238);
            this.comboBoxJUGA.Name = "comboBoxJUGA";
            this.comboBoxJUGA.Size = new System.Drawing.Size(302, 34);
            this.comboBoxJUGA.TabIndex = 14;
            this.comboBoxJUGA.SelectedIndexChanged += new System.EventHandler(this.comboBoxJUGA_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label8.Location = new System.Drawing.Point(162, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "JUGADOR";
            // 
            // comboBoxEQUIPO
            // 
            this.comboBoxEQUIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEQUIPO.DropDownWidth = 600;
            this.comboBoxEQUIPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.75F, System.Drawing.FontStyle.Bold);
            this.comboBoxEQUIPO.FormattingEnabled = true;
            this.comboBoxEQUIPO.Location = new System.Drawing.Point(60, 169);
            this.comboBoxEQUIPO.Name = "comboBoxEQUIPO";
            this.comboBoxEQUIPO.Size = new System.Drawing.Size(302, 34);
            this.comboBoxEQUIPO.TabIndex = 12;
            this.comboBoxEQUIPO.SelectedIndexChanged += new System.EventHandler(this.comboBoxEQUIPO_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label7.Location = new System.Drawing.Point(172, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "EQUIPO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label6.Location = new System.Drawing.Point(172, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "RAZON";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Conducta antideportiva",
            "Disidencia por palabra o acción.",
            "Violación continua de las leyes del juego.",
            "Retrasar la reanudación del juego.",
            "No respetar la distancia reglamentaria en la ejecución de un tiro libre, saque de" +
                " esquina o saque de banda.",
            "Entrar o volver a entrar en el terreno de juego sin el permiso del árbitro.",
            "Salir deliberadamente del terreno de juego sin el permiso del árbitro.",
            "Sacarse la camiseta al hacer un gol. En caso de tener otra camiseta abajo no será" +
                " sancionado con la tarjeta amarilla",
            "Ir a celebrar con la hinchada."});
            this.comboBox2.Location = new System.Drawing.Point(60, 100);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(302, 28);
            this.comboBox2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(20, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(381, 60);
            this.label5.TabIndex = 8;
            this.label5.Text = "TARJETA AMARILLA";
            // 
            // YellowCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 365);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxJUGA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxEQUIPO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YellowCard";
            this.Text = "YellowCard";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.YellowCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxJUGA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxEQUIPO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
    }
}