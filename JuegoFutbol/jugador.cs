using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoFutbol
{
    public class Jugador
    {
        private bool activo;
        private string nombre;
        public string apellido;
        private int num_jugador;
        private string posicion;
        private int tarjeta_amarilla = 0;
        private int tarjeta_roja = 0;
        public int faltas = 0;
        public List<string> detalle_faltas = new List<string>();
        private int penales = 0;
        private List<string> detalle_penal = new List<string>();
        public int pelotas_sacadas = 0;
        public int saques_corner = 0;
        public int goles = 0;
        public int goles_de_penal = 0;
       

        public Jugador(int num, string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            num_jugador = num;
            activo = true;
        }

        public void setPosicion(string x) { posicion = x; }

        public string getName()
        {
            string FirstNameInitial = Convert.ToString(nombre[0]).ToUpper() + ". ";
            string LastName = apellido.ToUpper();
            return num_jugador + ") " +  FirstNameInitial + LastName + " ("+ posicion +")";

        }

        public string getApellido() { return Convert.ToString(nombre[0]).ToUpper() + ". "+ apellido.ToUpper(); }

        public int getRoja() { return tarjeta_roja; }
        public int getAmarilla() { return tarjeta_amarilla; }
        public void setAmarilla (int ama)
        {
            if(ama >= 2 || tarjeta_amarilla >= 2)
            {
                tarjeta_amarilla = 2;
                tarjeta_roja = 1;
                string text = "DOS Tarjetas Amarillas " + apellido.ToUpper() + " ha quedado fuera del juego.";
                activo = false;
                MessageBox.Show(text, "Football Checker", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                tarjeta_amarilla += ama;
                if (tarjeta_amarilla >= 2) setAmarilla(2);
                else MessageBox.Show("Tarjeta Amarilla", "Football Checker", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void setRoja(int roja)
        {
            tarjeta_roja = roja;
            activo = false;
            MessageBox.Show("Tarjeta Roja | El Jugador" + apellido.ToUpper() + "Ha quedado fuera del juego", "Football Checker", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool getEstado() { return activo; }
        public void setDetalleFaltas(string x)
        {
            detalle_faltas.Add(x);
        }
        public string getDetalleFaltas()
        {
            string a = "";
            foreach(string b in detalle_faltas)
            {
                a += b + "\n";
            }
            return a;
        
        }

        public void setPenales(string penal)
        {
            penales++;
            detalle_penal.Add(penal);
        }

        public string getPenales()
        {
            string a = "";
            int i = 1;
            foreach(string b in detalle_penal)
            {
                a += i + ". " + b + "\n";
            }
            return a;
        }

        public string getData()
        {
            return getApellido() + "Goles: " + goles + " Penales: " + penales + " TA: " + tarjeta_amarilla + " TR: " + tarjeta_roja + "\n";
        }



    }
}
