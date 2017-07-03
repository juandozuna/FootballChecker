using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoFutbol
{
    public class team
    {
        public Jugador[] jugador = new Jugador[11];
        public Dictionary<int, string> formacion;
        private Formation formation;
        string nombre { get; set; }
        public int Score;
        public int faltas_cometidas = 0;
        public int penales = 0;
        public int goles_de_penal = 0;
        public int tarjetaAmarilla = 0;
        public int tarjetaRoja = 0;
        public int saquesDeBanda = 0;
        public int saquesCorner = 0;
        public int corner = 0;
        bool created = false;

        public team()
        {
            created = false;

        }

        public void setData(string nombre, string formacion)
        {
            this.nombre = nombre;
            Score = 0;
            formation = new Formation(formacion);
            this.formacion = (formation.getForm());
            created = true;

        }
        public bool teamCreated() { return created; }

        public string getStyle() { return formation.style; }

        public string getJugadores()
        {
            string players = "";
            foreach (Jugador a in jugador)
            {
                players += a.getName();
                players += "\n";
            }
            return players;
        }

        public string getName()
        {
            return nombre;
        }
        public int getScore() { return Score; }
        public int getFaltas() { return faltas_cometidas; }
        public int getPenales() { return penales; }
        public int getTarjetaAmarila() { return tarjetaAmarilla; }
        public int getTarjetaRoja() { return tarjetaRoja; }
        public int getSaqueBanda() { return saquesDeBanda; }

        

    }
}
