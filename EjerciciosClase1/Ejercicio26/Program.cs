using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 27";
            List<double> enteros = new List<double>(); ;
            int cantidad = 20;
            int i;
            Random r = new Random();
            for(i=0;i<cantidad;i++)
            {
                double numero = r.Next(-100, 100);
                if(numero!=0)
                {
                    enteros.Add(numero);
                    System.Threading.Thread.Sleep(100);
                }
            }
            foreach(double entero in enteros)
            {
                Console.WriteLine("Numero: {0}",entero);
            }

            enteros.Sort(Program.OrdenarDescendente);

            Console.WriteLine("---Ordenada Positivos---");
            foreach (double entero in enteros)
            {
                if(entero > 0)
                {
                    Console.WriteLine("Numero: {0}", entero);
                }
                
            }

            enteros.Sort();

            Console.WriteLine("---Ordenada Negativos---");
            foreach (double entero in enteros)
            {
                if (entero < 0)
                {
                    Console.WriteLine("Numero: {0}", entero);
                }

            }

            Console.ReadKey();

           
        }

        private static int OrdenarDescendente(double numero1, double numero2)
        {
            return -numero1.CompareTo(numero2);
        }

    }
}
