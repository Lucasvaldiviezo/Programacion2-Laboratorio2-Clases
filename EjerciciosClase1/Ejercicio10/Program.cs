using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 10";
            int cantLineas;
            string auxCantLineas;
            bool validar;
            int i;
            int j = 0;
            int k;
            Console.Write("Ingrese la cantidad de linea que tendra la piramide: ");
            auxCantLineas = Console.ReadLine();
            validar = int.TryParse(auxCantLineas, out cantLineas);
            if (validar)
            {
                k = cantLineas;
                for (i = 1; i <= cantLineas; i++)
                {
                    
                    do
                    {
                        do
                        {
                            Console.Write(" ");
                            k--;
                        } while (k >= i);
                        Console.Write("*");
                        j++;
                    }while (j < i);
                    k = cantLineas;
                    j = 0;
                    Console.WriteLine(" ");
                }
            }
            Console.ReadKey();
        }
    }
}
