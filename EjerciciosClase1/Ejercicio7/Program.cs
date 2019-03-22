using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 7";
            string dia;
            string mes;
            string año;
            bool validar;
            bool validar2;
            bool validar3;
            int diaParseado;
            int mesParseado;
            int añoParseado;
            int añoActual;
            int i;
            int totalDias=0;
            string flechaCompleta;
            
            Console.Write("Ingrese Dia de Nacimiento: ");
            dia = Console.ReadLine();
            Console.Write("Ingrese Mes de Nacimiento: ");
            mes = Console.ReadLine();
            Console.Write("Ingrese Año de Nacimiento: ");
            año = Console.ReadLine();

            flechaCompleta = dia;

            validar = int.TryParse(dia, out diaParseado);
            validar2 = int.TryParse(mes, out mesParseado);
            validar3 = int.TryParse(año, out añoParseado);
            añoActual = DateTime.Now.Year;
            
            if (validar && validar2 && validar3)
            {
                for (i = añoParseado; i <= añoActual; i++)
                {
                    if (i % 4 == 0 || i % 400 == 0)
                    {
                        totalDias = totalDias + 366;
                    }else
                    {
                        totalDias = totalDias + 365;

                    }
                }
            }
            Console.WriteLine("Usted vivio {0} dias hasta ahora",totalDias);
            Console.ReadKey();
        }
    }
}
