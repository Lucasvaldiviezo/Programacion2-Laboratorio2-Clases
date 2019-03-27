using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 9";
            int cantLineas;
            string auxCantLineas;
            bool validar;
            int i;
            int j = 0;
            Console.Write("Ingrese la cantidad de linea que tendra la piramide: ");
            auxCantLineas = Console.ReadLine();
            validar = int.TryParse(auxCantLineas, out cantLineas);
            if(validar)
            {
                for (i = 1; i <= cantLineas; i++)
                {
                    do
                    {
                        Console.Write("*");
                        j++;
                    } while (j < i);
                    j = 0;
                    Console.WriteLine(" ");
                }
            }
            Console.ReadKey();
        }
    }
}
