using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoFutbol
{
    class main
    {
        public static team[] equipo = new team[2];

        [STAThread]
        public static void Main(string[] args)
        {
            equipo[0] = new team();
            equipo[1] = new team();
            FootballMain sa = new FootballMain();
            sa.ShowDialog();

            if (equipo[0].teamCreated())
            {
                Equipos d = new Equipos();
                d.ShowDialog();
            }          

            if(equipo[0].teamCreated() && equipo[1].teamCreated())
            {
                TeamVS vs = new TeamVS(equipo[0].getName(),equipo[1].getName(),equipo[0].getStyle(), equipo[1].getStyle(),equipo[0].getJugadores(), equipo[1].getJugadores());
                vs.ShowDialog();
            }


        }
    }
}
