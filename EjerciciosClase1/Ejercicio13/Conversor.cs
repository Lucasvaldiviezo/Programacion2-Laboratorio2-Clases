using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Conversor
    {
        public static string DecimalBinario(double numero)
        {
            string cadena = "";
            double resto;
           
            do
            {
                resto = numero % 2;
                numero = numero / 2;
                if(resto==0)
                {
                    cadena = cadena + "0" ;
                }else if(resto==1)
                {
                    cadena = cadena + "1";
                }
            } while(numero >= 2);

            return cadena;
        }

        public static double BinarioDecimal(string binario)
        {
            double numero;
            
            

            return numero;
        }
    }
}
