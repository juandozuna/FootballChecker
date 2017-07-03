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
    public partial class Penal : Form
    {
        private int e, j;
        public Penal(int indexEquipo, int indexJugador)
        {
            InitializeComponent();
            e = indexEquipo;
            j = indexJugador;
            label2.Text = main.equipo[e].getName().ToUpper();
            label3.Text = main.equipo[e].jugador[j].getApellido();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.equipo[this.e].jugador[j].goles_de_penal++;
            main.equipo[this.e].jugador[j].setPenales("Gol de Penal");
            main.equipo[this.e].goles_de_penal++;
            main.equipo[this.e].Score++;
            MessageBox.Show("SE ANOTO UN GOL DE PENAL!", "Football Checker", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main.equipo[this.e].jugador[j].setPenales("Pelota Pasada");
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            main.equipo[this.e].jugador[j].setPenales("Tiro Fallido");
            Close();
        }

        private void Penal_Load(object sender, EventArgs e)
        {
        }
    }
}
