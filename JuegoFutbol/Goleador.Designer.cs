namespace JuegoFutbol
{
    partial class Goleador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Goleador));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Mensaje = new System.Windows.Forms.Label();
            this.AgregarGol = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(72, 51);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Mensaje
            // 
            this.Mensaje.BackColor = System.Drawing.Color.Silver;
            this.Mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mensaje.ForeColor = System.Drawing.Color.Black;
            this.Mensaje.Location = new System.Drawing.Point(-30, 20);
            this.Mensaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.Size = new System.Drawing.Size(416, 20);
            this.Mensaje.TabIndex = 1;
            this.Mensaje.Text = "Aqui va el texto";
            this.Mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgregarGol
            // 
            this.AgregarGol.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AgregarGol.Location = new System.Drawing.Point(72, 113);
            this.AgregarGol.Margin = new System.Windows.Forms.Padding(2);
            this.AgregarGol.Name = "AgregarGol";
            this.AgregarGol.Size = new System.Drawing.Size(73, 37);
            this.AgregarGol.TabIndex = 2;
            this.AgregarGol.Text = "Agregar Gol";
            this.AgregarGol.UseVisualStyleBackColor = false;
            this.AgregarGol.Click += new System.EventHandler(this.AgregarGol_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Cancelar.Location = new System.Drawing.Point(197, 113);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(62, 37);
            this.Cancelar.TabIndex = 3;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Goleador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(352, 182);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.AgregarGol);
            this.Controls.Add(this.Mensaje);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Goleador";
            this.Text = "Goleador";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Goleador_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Mensaje;
        private System.Windows.Forms.Button AgregarGol;
        private System.Windows.Forms.Button Cancelar;
    }
}