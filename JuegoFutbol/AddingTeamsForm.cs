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
    public partial class AddingTeamsForm : Form
    {
        public static int c = 0;
        public AddingTeamsForm(string title, string formacion)
        {
            InitializeComponent();
            label1Equipo.Text = title;
            label4ContentFormacion.Text = formacion;
            this.Focus();
           
        }

        private void button1UploadFile_Click(object sender, EventArgs e)
        {
            bool boole = false;
            do
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.CheckFileExists = true;
                openFileDialog.AddExtension = true;
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "FC Files (*.fcj)|*.fcj";
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        List<string[]> text = new List<string[]>();
                        string read;
                        while ((read = reader.ReadLine()) != null)
                        {
                            text.Add(read.Split(','));
                        }
                        if (text.Count > 11)
                        {
                            DialogResult result = MessageBox.Show("El archivo que intento subir tiene mas informacion de la esperada \n" +
             "El archivo solo puede contener 11 jugadores" +
             " \n Vuelva a intentarlo", "Football Checker", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            if (result == DialogResult.Retry) boole = true;
                    }
                        else
                        {
                            boole = false;
                            textBox1.Text = text[0][0];
                            textBox2.Text = text[0][1];
                            textBox3.Text = text[0][2];
                            textBox4.Text = text[1][0];
                            textBox5.Text = text[1][1];
                            textBox6.Text = text[1][2];
                            textBox7.Text = text[2][0];
                            textBox8.Text = text[2][1];
                            textBox9.Text = text[2][2];
                            textBox10.Text = text[3][0];
                            textBox11.Text = text[3][1];
                            textBox12.Text = text[3][2];
                            textBox13.Text = text[4][0];
                            textBox14.Text = text[4][1];
                            textBox15.Text = text[4][2];
                            textBox16.Text = text[5][0];
                            textBox17.Text = text[5][1];
                            textBox18.Text = text[5][2];
                            textBox19.Text = text[6][0];
                            textBox20.Text = text[6][1];
                            textBox21.Text = text[6][2];
                            textBox22.Text = text[7][0];
                            textBox23.Text = text[7][1];
                            textBox24.Text = text[7][2];
                            textBox25.Text = text[8][0];
                            textBox26.Text = text[8][1];
                            textBox27.Text = text[8][2];
                            textBox28.Text = text[9][0];
                            textBox29.Text = text[9][1];
                            textBox30.Text = text[9][2];
                            textBox31.Text = text[10][0];
                            textBox32.Text = text[10][1];
                            textBox33.Text = text[10][2];
                            MessageBox.Show("El archivo subio exitosamente", "Football Checker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                    }

                }
            } while (boole);
        }

        public void setLabel1TituloText(string x)
        {
            label1Equipo.Text = x;
        }

        public void setLabel4FormacionText(string x)
        {
            label4ContentFormacion.Text = x;
        }

        private void AddingTeamsForm_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox16.Text == "" || textBox17.Text == "" || textBox18.Text == "" || textBox19.Text == "" || textBox20.Text == "" || textBox21.Text == "" || textBox22.Text == "" || textBox23.Text == "" || textBox24.Text == "" || textBox25.Text == "" || textBox26.Text == "" || textBox27.Text == "" || textBox28.Text == "" || textBox29.Text == "" || textBox30.Text == "" || textBox31.Text == "" || textBox32.Text == "" || textBox33.Text == "") { MessageBox.Show("Debe de llenar todos los campos","Football Checker",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            else
            {
                int x;
                Int32.TryParse(textBox1.Text, out x);
                main.equipo[c].jugador[0] = new Jugador(x, textBox2.Text, textBox3.Text);
                main.equipo[c].jugador[0].setPosicion(main.equipo[c].formacion[x]);
                Int32.TryParse(textBox4.Text, out x);
                main.equipo[c].jugador[1] = new Jugador(x, textBox5.Text, textBox6.Text);
                main.equipo[c].jugador[1].setPosicion(main.equipo[c].formacion[x]);
                Int32.TryParse(textBox7.Text, out x);
                main.equipo[c].jugador[2] = new Jugador(x, textBox8.Text, textBox9.Text);
                main.equipo[c].jugador[2].setPosicion(main.equipo[c].formacion[x]);
                Int32.TryParse(textBox10.Text, out x);
                main.equipo[c].jugador[3] = new Jugador(x, textBox11.Text, textBox12.Text);
                main.equipo[c].jugador[3].setPosicion(main.equipo[c].formacion[x]);
                Int32.TryParse(textBox13.Text, out x);
                main.equipo[c].jugador[4] = new Jugador(x, textBox14.Text, textBox15.Text);
                main.equipo[c].jugador[4].setPosicion(main.equipo[c].formacion[x]);
                Int32.TryParse(textBox16.Text, out x);
                main.equipo[c].jugador[5] = new Jugador(x, textBox17.Text, textBox18.Text);
                main.equipo[c].jugador[5].setPosicion(main.equipo[c].formacion[x]);
                Int32.TryParse(textBox19.Text, out x);
                main.equipo[c].jugador[6] = new Jugador(x, textBox20.Text, textBox21.Text);
                main.equipo[c].jugador[6].setPosicion(main.equipo[c].formacion[x]);
                Int32.TryParse(textBox22.Text, out x);
                main.equipo[c].jugador[7] = new Jugador(x, textBox23.Text, textBox24.Text);
                main.equipo[c].jugador[7].setPosicion(main.equipo[c].formacion[x]);
                Int32.TryParse(textBox25.Text, out x);
                main.equipo[c].jugador[8] = new Jugador(x, textBox26.Text, textBox27.Text);
                main.equipo[c].jugador[8].setPosicion(main.equipo[c].formacion[x]);
                Int32.TryParse(textBox28.Text, out x);
                main.equipo[c].jugador[9] = new Jugador(x, textBox29.Text, textBox30.Text);
                main.equipo[c].jugador[9].setPosicion(main.equipo[c].formacion[x]);
                Int32.TryParse(textBox31.Text, out x);
                main.equipo[c].jugador[10] = new Jugador(x, textBox32.Text, textBox33.Text);
                main.equipo[c].jugador[10].setPosicion(main.equipo[c].formacion[x]);
                c++;
                Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
