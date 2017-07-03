using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoFutbol
{
    public partial class CornerSalida : Form
    {
        public CornerSalida()
        {
            InitializeComponent();
            foreach (team a in main.equipo)
            {
                comboBox1.Items.Add(a.getName());
            }
        }

        private void CornerSalida_Load(object sender, EventArgs e)
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

                foreach (Jugador a in main.equipo[1].jugador)
                {
                    if (a.getEstado()) comboBox3.Items.Add(a.getApellido());
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Text = main.equipo[0].getName();
                foreach (Jugador a in main.equipo[0].jugador)
                {
                    if (a.getEstado()) comboBox3.Items.Add(a.getApellido());
                }
            }
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indE = comboBox1.SelectedIndex;
            int indJ = comboBox2.SelectedIndex;
            main.equipo[indE].saquesCorner++;
            main.equipo[indE].jugador[indJ].saques_corner++;
            if (indE == 1) main.equipo[0].corner++;
            else main.equipo[1].corner++;
        }
    }
}
