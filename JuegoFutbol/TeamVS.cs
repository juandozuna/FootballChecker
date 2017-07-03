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
    public partial class TeamVS : Form
    {
        public TeamVS(string nomEquipo1, string nomEquipo2, string equipo1Formacion, string equipo2Formacion, string JugadoresEquipo1, string JugadoresEquipo2)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            labelNomEquipo1.Text = nomEquipo1;
            labelNomEquipo2.Text = nomEquipo2;
            labelFormacionEquipo1.Text = equipo1Formacion;
            labelFormacionEquipo2.Text = equipo2Formacion;
            labelJugadoresEquipo1.Text = JugadoresEquipo1;
            labelJugadoresEquipo2.Text = JugadoresEquipo2;
            button2.Enabled = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TeamVS_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Partido Game = new Partido(main.equipo[0].getName(), main.equipo[1].getName());

            Game.ShowDialog();
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowInfo si = new ShowInfo(main.equipo[0].getScore(), main.equipo[0].getTarjetaRoja(), main.equipo[0].getTarjetaAmarila(), main.equipo[0].getPenales(), main.equipo[1].getScore(), main.equipo[1].getTarjetaRoja(), main.equipo[1].getTarjetaAmarila(), main.equipo[1].getPenales());
            si.ShowDialog();
        }
    }
}
