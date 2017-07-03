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
    public partial class RedCard : Form
    {
        public RedCard()
        {
            InitializeComponent();
            foreach(team a in main.equipo)
            {
                comboBoxEQUIPO.Items.Add(a.getName());
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxEQUIPO.SelectedIndex;
            foreach(Jugador a in main.equipo[index].jugador)
            {
                if (a.getEstado()) comboBoxJUGA.Items.Add(a.getApellido());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indE = comboBoxEQUIPO.SelectedIndex;
            int indJ = comboBoxJUGA.SelectedIndex;
            main.equipo[indE].tarjetaRoja = 1;
            main.equipo[indE].jugador[indJ].setRoja(1);
        }

        private void YellowCard_Load(object sender, EventArgs e)
        {

        }
    }
}
