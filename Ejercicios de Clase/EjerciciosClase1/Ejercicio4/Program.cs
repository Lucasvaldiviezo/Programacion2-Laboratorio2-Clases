using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 4";
            int numeroActual=0;
            int j;
            int perfectos=0;
            int suma;;
            Console.WriteLine("Buscando numeros perfectos... ");

            do
            {
                numeroActual++;
                suma = 0;
                for (j = 1; j < numeroActual; j++)
                {
                    if (numeroActual % j == 0)
                    {
                        suma = suma + j;
                    }
                }
                if (suma == numeroActual)
                {
                    Console.WriteLine("El primer numero perfecto es: {0}", suma);
                    perfectos++;
                }
            } while (perfectos != 4);


            Console.ReadKey();
        }
    }
}
