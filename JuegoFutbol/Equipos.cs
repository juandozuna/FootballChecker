using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoFutbol
{
    public partial class Equipos : Form
    {
        private static int contar = 0;
        public Equipos()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            button2.Visible = false;

            if (contar == 1)
            {
                button1.Visible = false;
                button2.Visible = true;
                label1.Text = "EQUIPO 2";
            }

        }

        private void Equipos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        public void title(string l)
        {
           label1.Text = l;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = nombreBox.Text;
            string b = FormacionComboBox1.Text;
            if (FormacionComboBox1.Text != "")
            {
                Close();
                main.equipo[0].setData(a, b);
                button1.Visible = false;
                button2.Visible = true;
                string text = "";
                for (int i = 1; i <= 11; i++)
                {
                    text += main.equipo[0].formacion[i] + "\n";
                }
                AddingTeamsForm tf = new AddingTeamsForm("EQUIPO 1: " + a, text);
                contar++;
                tf.ShowDialog();
      
            }
            else MessageBox.Show("Debe seleccionar una formacion", "Football Checker", MessageBoxButtons.OK, MessageBoxIcon.Error);
     
        }

        private void FormacionComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             * 3-5-2 3defensas, 5mediocampo, 1Delantero, 1Portero
             * 4-3-3 4defensas, 3mediocampo, 3delantero, 1Portero
             * 4-4-2 4Defensas, 4mediocampo, 2Delantero, 1Portero
             */
            string x = FormacionComboBox1.Text;
            switch (x.ToLower())
            {
                case "3-5-2":
                    labelAFormacion.Text = "3 Defensas, 5 MedioCampo, 1 Delantero, 1 Portero";
                    break;
                case "4-3-3":
                    labelAFormacion.Text = "4 Defensas, 3 Defensas, 3 Delanteros, 1 Portero";
                    break;
                case "4-4-2":
                    labelAFormacion.Text = "4 Defensas, 4 Defensas, 2 Delanero, 1 Portero";
                    break;
                default:
                    labelAFormacion.Text = "";
                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = nombreBox.Text;
            string b = FormacionComboBox1.Text;
            if (FormacionComboBox1.Text != "")
            {
                main.equipo[1].setData(a, b);
                string text = "";
                for (int i = 1; i <= 11; i++)
                {
                    text += main.equipo[1].formacion[i] + "\n";
                }
                AddingTeamsForm tf = new AddingTeamsForm("EQUIPO 2: " + a, text);
                tf.ShowDialog();
                
                this.Close();
            }
            else MessageBox.Show("Debe seleccionar una formacion", "Football Checker", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "FC Files (*.fce)|*.fce";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               using(StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    List<string> text = new List<string>();
                    string read;
                    while ((read = reader.ReadLine()) != null)
                    {
                        text.Add(read);
                    }
                    main.equipo[contar].setData(text[0], text[1]);
                    
                    for(int i = 2; i < text.Count; i++)
                    {
                        string[] data = text[i].Split(',');
                        int num;
                        Int32.TryParse(data[0], out num);
                        main.equipo[contar].jugador[i - 2] = new Jugador(num, data[1], data[2]);
                        main.equipo[contar].jugador[i - 2].setPosicion(main.equipo[contar].formacion[num]);

                    }
                    MessageBox.Show("El equipo ha sido agregado exitosamente", "Football Checker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddingTeamsForm.c++;
                }

                contar++;
                Close();
            }
        }

        private void labelAFormacion_Click(object sender, EventArgs e)
        {

        }
    }
}
