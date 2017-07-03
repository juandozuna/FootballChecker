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
    public partial class FootballMain : Form
    {
        public FootballMain()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void FootballMain_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Equipos d = new Equipos();
                if (main.equipo[1].teamCreated() && main.equipo[0].teamCreated()) { } //teams created
                else d.ShowDialog();
                button1.Visible = false;
                this.Close();
            }
            catch (NullReferenceException) { }
        }
    }
}
