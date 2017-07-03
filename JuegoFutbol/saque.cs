using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoFutbol
{
    public partial class saque : Form
    {
        public saque()
        {
            InitializeComponent();
            foreach(team a in main.equipo)
            {
                comboBox1.Items.Add(a.getName());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saque_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Jugador a in main.equipo[comboBox1.SelectedIndex].jugador)
            {
                if (a.getEstado()) comboBox2.Items.Add(a.getApellido());
            }
            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Text = main.equipo[1].getName();
               
                foreach(Jugador a in main.equipo[1].jugador)
                {
                    if (a.getEstado()) comboBox3.Items.Add(a.getApellido());
                }
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                textBox1.Text = main.equipo[0].getName();
                foreach (Jugador a in main.equipo[0].jugador)
                {
                    if (a.getEstado()) comboBox3.Items.Add(a.getApellido());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indE = comboBox1.SelectedIndex;
            int indJ = comboBox2.SelectedIndex;
            main.equipo[indE].saquesDeBanda++;
            main.equipo[indE].jugador[indJ].pelotas_sacadas++;Close();


        }
    }
}
