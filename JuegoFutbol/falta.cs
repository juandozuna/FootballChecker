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
    public partial class FALTA : Form
    {
        public int indexInfractorE;
        public int indexVictimaE;
        public int indexJugadorInfractor;
        public int indexJugadorVictima;
        public FALTA()
        {
            InitializeComponent();
            comboBoxEquipoVictima.Enabled = false;
            foreach(team a in main.equipo)
            {
                comboBoxEquipoInfractor.Items.Add(a.getName());
            }
        }

        private void FALTA_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxJugadoresInfractor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEquipoInfractor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i;
            for(i = 0; i < 2; i++)
            {
                if(comboBoxEquipoInfractor.Text == main.equipo[i].getName())
                {
                    break;
                }
            }           
            if (i == 0)
            {
                if (comboBoxEquipoVictima.Items.Count > 1) comboBoxEquipoVictima.Items.Clear();
                comboBoxEquipoVictima.Items.Add(main.equipo[1].getName());
                comboBoxEquipoVictima.SelectedItem = 0;
            } 
            else if(i == 1)
            {
                if (comboBoxEquipoVictima.Items.Count > 1) comboBoxEquipoVictima.Items.Clear();
                comboBoxEquipoVictima.Items.Add(main.equipo[0].getName());
                comboBoxEquipoVictima.SelectedItem = 0;
            }
            foreach(Jugador a in main.equipo[i].jugador)
            {
                if (a.getEstado())
                { comboBoxJugadoresInfractor.Items.Add(a.getApellido()); }
            }
            comboBoxEquipoVictima.Enabled = true;
        }

        private void comboBoxEquipoVictima_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < 2; i++)
            {
                if (comboBoxEquipoVictima.Text == main.equipo[i].getName())
                {
                    break;
                }
            }
            foreach (Jugador a in main.equipo[i].jugador)
            {
                if (a.getEstado())
                { comboBoxJugadoresVictima.Items.Add(a.getApellido()); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            indexJugadorInfractor = comboBoxJugadoresInfractor.SelectedIndex;
            indexJugadorVictima = comboBoxJugadoresVictima.SelectedIndex;
            indexInfractorE = comboBoxEquipoVictima.SelectedIndex;
            if(indexInfractorE == 0) { indexVictimaE = 1; } else if(indexInfractorE == 1) { indexVictimaE = 0; }
            //Codigo referente al infractor
            main.equipo[indexInfractorE].faltas_cometidas++;
            main.equipo[indexInfractorE].jugador[indexJugadorInfractor].faltas++;
            main.equipo[indexInfractorE].jugador[indexJugadorInfractor].setDetalleFaltas(comboBoxTipoFalta.Text);
            main.equipo[indexInfractorE].jugador[indexJugadorInfractor].setAmarilla(1);

            //Codigo referente al jugador con tiro libre
            main.equipo[indexVictimaE].penales++;
            Penal penal = new Penal(indexVictimaE, indexJugadorVictima); penal.ShowDialog();

            Close();
            //MessageBox.Show(Convert.ToString(indexJugadorInfractor), "TEST", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}