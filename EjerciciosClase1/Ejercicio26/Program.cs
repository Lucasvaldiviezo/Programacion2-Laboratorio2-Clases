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
            Console.Title = "Ejercicio 26";
            List<double> enteros = new List<double>(); ;
            int cantidad = 20;
            int i;
            Random rnd = new Random();
            for(i=0;i<cantidad;i++)
            {
                double numero = rnd.Next(-100, 100);
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

            Console.ReadKey();
        }
    }
}
