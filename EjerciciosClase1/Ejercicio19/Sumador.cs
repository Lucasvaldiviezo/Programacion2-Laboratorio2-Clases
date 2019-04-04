using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantSumas)
        {
            this.cantidadSumas = cantSumas;
        }
        public Sumador() : this(0){ }

        public long Sumar(long numero1, long numero2)
        {
            long numeroRetorno;

            this.cantidadSumas++;
            numeroRetorno = numero1 + numero2;

            return numeroRetorno;
        }

        public string Sumar(string cadena1, string cadena2)
        {
            string cadenaRetorno;

            this.cantidadSumas++;
            cadenaRetorno =  cadena1 + cadena2;

            return cadenaRetorno;
        }

        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            long resultado;
            resultado = s1.cantidadSumas + s2.cantidadSumas;
            return resultado;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool resultado=false;
            if (s1.cantidadSumas == s2.cantidadSumas)
                resultado = true;
            return resultado;
        }


    }
}
