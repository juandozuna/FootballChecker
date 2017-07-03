using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoFutbol
{
   public  class Formation
    {
        /*
             * 3-5-2 3defensas, 5mediocampo, 1Delantero, 1Portero
             * 4-3-3 4defensas, 3mediocampo, 3delantero, 1Portero
             * 4-4-2 4Defensas, 4mediocampo, 2Delantero, 1Portero
             */
       public Dictionary<int, String> form = new Dictionary<int, string>();
       public string style;
        public Formation(string formacion)
        {
            style = formacion;
            variableSetting(style);
        }

        public void variableSetting(string x)
        {
            switch (x.ToLower())
            {
                case "3-5-2":
                    form.Add(2,"2. Defensa Lateral Izquierdo");
                    form.Add(3, "3. Defensa Central");
                    form.Add(4, "4. Defensa Lateral Derech0");
                    form.Add(5, "5. Mediocampo Lateral Izquierdo");
                    form.Add(6, "6. Mediocampo Izquierda");
                    form.Add(7, "7. Mediocampo Central");
                    form.Add(8, "8. Mediocampo derecha");
                    form.Add(9, "9. Mediocampo Lateral Derecho");
                    form.Add(10, "10. Delantero Izquierda");
                    form.Add(11, "11. Delantero Derecha");
                    form.Add(1, "1. Portero");         
                    break;
                case "4-3-3":
                    form.Add(2, "2. Defensa Lateral Izquierdo");
                    form.Add(3, "3. Defensa Central Izquierdo");
                    form.Add(4, "4. Defensa Central Derecho");
                    form.Add(5, "5. Defensa Lateral Derecho");
                    form.Add(6, "6. Mediocampo Izquierda");
                    form.Add(7, "7. Mediocampo Central");
                    form.Add(8, "8. Mediocampo derecha");
                    form.Add(9, "9. Delantero Izquierda");
                    form.Add(10, "10. Delantero Central");
                    form.Add(11, "11. Delantero Derecha");
                    form.Add(1, "1. Portero");
                    break;
                case "4-4-2":
                    form.Add(2, "2. Defensa Lateral Izquierdo");
                    form.Add(3, "3. Defensa Central Izquierdo");
                    form.Add(4, "4. Defensa Central Derecho");
                    form.Add(5, "5. Defensa Lateral Derecho");
                    form.Add(6, "6. Mediocampo Izquierda");
                    form.Add(7, "7. Mediocampo Central izquierda");
                    form.Add(8, "8. Mediocampo central derecha");
                    form.Add(9, "9. Mediocampo derecha");
                    form.Add(10, "10. Delantero Izquierda");
                    form.Add(11, "11. Delantero Derecha");
                    form.Add(1, "1. Portero");
                    break;
                default:
                    MessageBox.Show("La Formacion ingresada no existe", "Football Checker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

            }
        }

        public Dictionary<int, string> getForm () { return form; }
    }
}
