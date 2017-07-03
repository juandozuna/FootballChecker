namespace JuegoFutbol
{
    partial class Equipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.FormacionComboBox1 = new System.Windows.Forms.ComboBox();
            this.labelAFormacion = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 48.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(5, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 92);
            this.label1.TabIndex = 0;
            this.label1.Text = "EQUIPO 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aquamarine;
            this.label2.Location = new System.Drawing.Point(43, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nombreBox
            // 
            this.nombreBox.BackColor = System.Drawing.Color.OldLace;
            this.nombreBox.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreBox.ForeColor = System.Drawing.Color.Black;
            this.nombreBox.Location = new System.Drawing.Point(287, 120);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nombreBox.Size = new System.Drawing.Size(292, 41);
            this.nombreBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aquamarine;
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 56);
            this.label3.TabIndex = 3;
            this.label3.Text = "Formacion:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(157, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "INGRESAR";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormacionComboBox1
            // 
            this.FormacionComboBox1.BackColor = System.Drawing.Color.OldLace;
            this.FormacionComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormacionComboBox1.DropDownWidth = 400;
            this.FormacionComboBox1.Font = new System.Drawing.Font("Arial", 18.25F);
            this.FormacionComboBox1.ForeColor = System.Drawing.Color.Black;
            this.FormacionComboBox1.FormattingEnabled = true;
            this.FormacionComboBox1.ItemHeight = 27;
            this.FormacionComboBox1.Items.AddRange(new object[] {
            "3-5-2",
            "4-3-3",
            "4-4-2",
            "   "});
            this.FormacionComboBox1.Location = new System.Drawing.Point(289, 189);
            this.FormacionComboBox1.Name = "FormacionComboBox1";
            this.FormacionComboBox1.Size = new System.Drawing.Size(292, 35);
            this.FormacionComboBox1.TabIndex = 5;
            this.FormacionComboBox1.SelectedIndexChanged += new System.EventHandler(this.FormacionComboBox1_SelectedIndexChanged);
            // 
            // labelAFormacion
            // 
            this.labelAFormacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAFormacion.BackColor = System.Drawing.Color.Transparent;
            this.labelAFormacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAFormacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelAFormacion.Location = new System.Drawing.Point(53, 163);
            this.labelAFormacion.Name = "labelAFormacion";
            this.labelAFormacion.Size = new System.Drawing.Size(530, 23);
            this.labelAFormacion.TabIndex = 6;
            this.labelAFormacion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelAFormacion.Click += new System.EventHandler(this.labelAFormacion_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(157, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "INGRESAR";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(139, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(303, 31);
            this.button3.TabIndex = 8;
            this.button3.Text = "Subir Archivo de Equipo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImage = global::JuegoFutbol.Properties.Resources.field_big;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(593, 297);
            this.Controls.Add(this.labelAFormacion);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FormacionComboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombreBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Brown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Equipos";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Equipos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Equipos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreBox;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox FormacionComboBox1;
        private System.Windows.Forms.Label labelAFormacion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}