using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 20";
            Peso peso1 = new Peso(100);
            Peso peso2 = new Peso(100);
            Peso peso3 = new Peso(100);
            Dolar dolar1 = new Dolar(100);
            Dolar dolar2 = new Dolar(100);
            Dolar dolar3 = new Dolar(100);
            Euro euro1 = new Euro(100);
            Euro euro2 = new Euro(100);
            Euro euro3 = new Euro(100);

            euro2 = (Euro)dolar1;
            euro3 = (Euro)peso1;
            peso2 = (Peso)dolar1;
            peso3 = (Peso)euro1;
            dolar2 = (Dolar)peso1;
            dolar3 = (Dolar)euro1;

            Console.WriteLine("El dolar1 a euro2 vale: {0}", euro2.GetCantidad());
            Console.WriteLine("\nEl peso1 a euro3 vale: {0}", euro3.GetCantidad());
            Console.WriteLine("\nEl dolar1 a peso2 vale: {0}", peso2.GetCantidad());
            Console.WriteLine("\nEl euro1 a peso3 vale: {0}", peso3.GetCantidad());
            Console.WriteLine("\nEl peso1 a dolar2 vale: {0}", dolar2.GetCantidad());
            Console.WriteLine("\nEl euro1 a dolar3 vale: {0}", dolar3.GetCantidad());
            Console.ReadKey();
        }
    }
}
