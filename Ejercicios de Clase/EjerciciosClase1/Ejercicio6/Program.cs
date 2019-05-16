using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 6";
            string año1;
            string año2;
            bool validar;
            bool validar2;
            int año1Convertido;
            int año2Convertido;
            int i;

            Console.Write("Ingrese el primer año: ");
            año1 = Console.ReadLine();
            Console.Write("Ingrese el segundo año: ");
            año2 = Console.ReadLine();
            validar = int.TryParse(año1, out año1Convertido);
            validar2= int.TryParse(año2, out año2Convertido);

            if(validar && validar2)
            {
                for(i=año1Convertido; i<=año2Convertido;i++)
                {
                    if(i%4==0 || i%400==0)
                    {
                        Console.WriteLine("El año {0} es bisiesto", i);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
