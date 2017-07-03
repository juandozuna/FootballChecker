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
    public partial class Partido : Form
    {
        public Partido(string nombreequipo1, string nombreequipo2)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Team1.Text = nombreequipo1;
            Team2.Text = nombreequipo2;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            CornerSalida cs = new CornerSalida();
        }

        private void GolIzquierdo_Click(object sender, EventArgs e)
        {
            Goleador Goleador = new Goleador(main.equipo[1],0);
            Goleador.ShowDialog();
            labelPunto2.Text = Convert.ToString(main.equipo[0].getScore());
           
        }

        private void GolDerecho_Click(object sender, EventArgs e)
        {
           
            Goleador Goleador = new Goleador(main.equipo[0],1);
            Goleador.ShowDialog();
            labelPunto1.Text = Convert.ToString(main.equipo[1].getScore());
   
          
       
        }

        private void Partido_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //faltas
        {
            FALTA falta = new FALTA();
            falta.ShowDialog();
            labelPunto1.Text = Convert.ToString(main.equipo[1].getScore());
            labelPunto2.Text = Convert.ToString(main.equipo[0].getScore());
        }

        private void button2_Click_1(object sender, EventArgs e) //tarjeta amarilla
        {
            YellowCard yc = new YellowCard();
            yc.ShowDialog();
        }

        private void BandaInferior_Click(object sender, EventArgs e)
        {
            saque saq = new saque(); saq.ShowDialog();
        }

        private void BandaSuperior_Click(object sender, EventArgs e)
        {
            saque saq = new saque(); saq.ShowDialog();
        }

        private void buttonTarjetaRoja_Click(object sender, EventArgs e)
        {
            RedCard rc = new RedCard();
            rc.ShowDialog();
        }

        private void CornerSuperiorDerecho_Click(object sender, EventArgs e)
        {
            CornerSalida cs = new CornerSalida();
        }

        private void CornerInferiorDerecho_Click(object sender, EventArgs e)
        {
            CornerSalida cs = new CornerSalida();
        }

        private void CornerSuperiorIzquierdo_Click(object sender, EventArgs e)
        {
            CornerSalida cs = new CornerSalida();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Close();
        }
    }
}
