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
    public partial class Goleador : Form
    {
        int index;
        public Goleador(team Equipo, int index)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Mensaje.Text = "Que miembro del " + Equipo.getName() +" anoto el gol?";
            for (int i = 0; i < Equipo.jugador.Count(); i++)
            {
                if (Equipo.jugador[i].getEstado())
                { comboBox1.Items.Add(Equipo.jugador[i].apellido); }
            }
            this.index = index;
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        public void AgregarGol_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < 11; i++)
            {
                if (comboBox1.SelectedItem.Equals(main.equipo[index].jugador[i].apellido))
                {
                    main.equipo[index].jugador[i].goles++;
                    break;
                }
            }
            main.equipo[index].Score++;
            try
            {
                MessageBox.Show(main.equipo[index].jugador[i].apellido.ToUpper() + " ANOTO UN GOL!!!" + main.equipo[index].getScore(), "Football Checker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (IndexOutOfRangeException) { }
            Close();
             
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Goleador_Load(object sender, EventArgs e)
        {

        }
    }
}
