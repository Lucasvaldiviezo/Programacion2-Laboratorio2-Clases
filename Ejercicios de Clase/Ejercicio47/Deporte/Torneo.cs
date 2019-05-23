﻿using System;
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

        public Torneo(string nombre)
        {
           this.nombre = nombre;
            equipos = new List<T>();
        }

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
            return !(t == e);
        }

        public static Torneo<T> operator +(Torneo<T> t, T e)
        {

            if(t != e)
            {
                t.equipos.Add(e);
            }

            return t;
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
            resultado2 = random.Next(0,10);
            calcular.AppendLine("Equipo 1 - Resultados - Equipo2");
            calcular.AppendFormat("[{0}]   [{1}]- [{2}]  [{3}]", equipo1.nombre, resultado1, resultado2,equipo2.nombre);

            return calcular.ToString();
        }

        public string JugarPartido()
        {
            Random random = new Random();
            string resultado;
            int indice1; 
            int indice2;

            do
            {
                indice1 = random.Next(0, equipos.Count);
                System.Threading.Thread.Sleep(1000);
                indice2 = random.Next(0, equipos.Count);

            } while (equipos[indice1] != equipos[indice2]);
            resultado = CalcularPartida(equipos[indice1], equipos[indice2]);

            return resultado;
        }
    }
}
