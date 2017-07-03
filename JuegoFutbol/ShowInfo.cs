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
    public partial class ShowInfo : Form
    {
        public ShowInfo(int scoreE1, int TRE1, int TAE1, int penalesE1, int scoreE2, int TRE2, int TAE2, int penalesE2)
        {
            InitializeComponent();
            labelEquipo1Goles.Text = Convert.ToString(scoreE1);
            label4GolesEquipo2.Text = Convert.ToString(scoreE2);
            label5TAEquipo2.Text = Convert.ToString(TAE2);
            label6TREquipo2.Text = Convert.ToString(TRE2);
            label3PenalesEquipo2.Text = Convert.ToString(penalesE2);
            labelEquipo1TA.Text = Convert.ToString(TAE1);
            labelEquipo1TR.Text = Convert.ToString(TRE1);
            labelEquipo1Penales.Text = Convert.ToString(penalesE1);
            string x = "";
            string y = "";

            foreach(Jugador a in main.equipo[0].jugador)
            {
                x += a.getData();
            }
            foreach (Jugador a in main.equipo[1].jugador)
            {
                y += a.getData();
            }
            labelJugadoresEquipo1.Text = x;
            label4JugadoresEquipo2.Text = y;
            

        }

        private void ShowInfo_Load(object sender, EventArgs e)
        {

        }

        private void labelJugadoresEquipo1_Click(object sender, EventArgs e)
        {

        }
    }
}
