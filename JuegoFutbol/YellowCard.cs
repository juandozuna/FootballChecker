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
    public partial class YellowCard : Form
    {
        public YellowCard()
        {
            InitializeComponent();
            foreach (team a in main.equipo)
            {
                comboBoxEQUIPO.Items.Add(a.getName());
            }
        }

        private void YellowCard_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxEQUIPO_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxEQUIPO.SelectedIndex;
            foreach (Jugador a in main.equipo[index].jugador)
            {
                if (a.getEstado()) comboBoxJUGA.Items.Add(a.getApellido());
            }
        }

        private void comboBoxJUGA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indE = comboBoxEQUIPO.SelectedIndex;
            int indJ = comboBoxJUGA.SelectedIndex;
            main.equipo[indE].tarjetaAmarilla++;
            main.equipo[indE].jugador[indJ].setAmarilla(1);
        }
    }
}
