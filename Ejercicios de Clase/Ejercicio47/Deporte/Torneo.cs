using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deporte
{
    public class Torneo<T> where T : Equipo
    {
        public string nombre;
        public List<T> equipos;

        public static bool operator ==(Torneo<T> t, T e)
        {
            bool retorno = false;
            foreach(T equipo in t.equipos)
            {
                if(equipo == e)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Torneo<T> t, T e)
        {
            return (t == e);
        }

        public static bool operator +(Torneo<T> t, T e)
        {
            bool retorno = false;
            if(t != e)
            {
                t.equipos.Add(e);
                retorno = true;
            }

            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendLine(nombre);
            foreach(T equipo in this.equipos)
            {
                mostrar.AppendFormat(equipo.Ficha());
            }

            return mostrar.ToString();
        }

        private string CalcularPartida(T equipo1, T equipo2)
        {
            Random random = new Random();
            double resultado1, resultado2;
            StringBuilder calcular = new StringBuilder();
            resultado1 = random.Next(0,10);
            System.Threading.Thread.Sleep(1000);
            resultado2 = random.Next();
            calcular.AppendFormat("[{0}] [{1}]-[{2}] [{3}]", equipo1.nombre, resultado1, equipo2.nombre, resultado2);

            return calcular.ToString();
        }

        public string JugarPartido()
        {
            Random random = new Random();
            string resultado;
            int indice1 = random.Next(0,equipos.Count-1);
            System.Threading.Thread.Sleep(1000);
            int indice2 = random.Next(0, equipos.Count-1);

            CalcularPartida(equipos[indice1], equipos[indice2]);


        }
    }
}
