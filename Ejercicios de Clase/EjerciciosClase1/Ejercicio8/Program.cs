using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 8";
            int hora;
            string nombre;
            string auxHora;
            string auxAntiguedad;
            string auxCantHoras;
            int antiguedad;
            int cantHoras;
            int seguir = 1;
            string auxSeguir;
            bool validar;
            bool validar2;
            bool validar3;
            float total;
            float descuento;

            do
            {
                Console.Write("Ingrese Nombre del empleado: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese la antigüedad del empleado: ");
                auxAntiguedad = Console.ReadLine();
                Console.Write("Ingrese la cantidad de horas trabajadas del empleado: ");
                auxCantHoras = Console.ReadLine();
                Console.Write("Ingrese lo que cobra por hora el empleado: ");
                auxHora = Console.ReadLine();
                validar = int.TryParse(auxHora, out hora);
                validar2 = int.TryParse(auxAntiguedad, out antiguedad);
                validar3 = int.TryParse(auxCantHoras, out cantHoras);
                if(validar && validar2 && validar3)
                {
                    total = hora * cantHoras;
                    total = total + antiguedad * 150;
                    descuento = total * 13 / 100;
                    total = total - descuento;
                    Console.WriteLine("El sueldo final del empleado es: {0}",total);
                    Console.WriteLine("¿Desea ingresar otro empleado? 1=Si / 0 = No:");
                    auxSeguir = Console.ReadLine();
                    int.TryParse(auxSeguir, out seguir);
                    if(seguir==0)
                    {
                        Console.WriteLine("¡Hasta pronto!");
                    }else
                    {
                        Console.Clear();
                    }
                }
            } while (seguir == 1);
            Console.ReadKey();
        }
    }
}
