using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 10";
            string auxValor;
            int valor;
            int minimo = -100;
            int maximo = 100;
            int minimoActual = int.MaxValue;
            int maximoActual = int.MinValue;
            float total=0;
            float promedio;
            bool validar;
            int i;
            int cantNumeroEntero = 10;
            for(i=0;i<cantNumeroEntero;i++)
            {
                Console.Write("Ingrese el valor {0}: ",i+1);
                auxValor = Console.ReadLine();
                validar = int.TryParse(auxValor, out valor);
                if (validar)
                {
                    validar = Validacion.Validar(valor, minimo, maximo);
                    if(validar)
                    {
                        total = total + valor;
                        if(valor > maximoActual)
                        {
                            maximoActual = valor;
                        }
                        if (valor < minimoActual)
                        {
                            minimoActual = valor;
                        }
                    }else
                    {
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine("Ese valor supera los limites, no se tomara en cuenta");
                        Console.WriteLine("-----------------------------------------------");
                    }
                }else
                {
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Eso no es un numero");
                    Console.WriteLine("-------------------");
                }
            }
            promedio = total / cantNumeroEntero;
            Console.Clear();
            Console.WriteLine("El promedio es: {0}",promedio);
            Console.WriteLine("El valor minimo es: {0}",minimoActual);
            Console.WriteLine("El valor maximo es: {0}",maximoActual);

            Console.ReadKey();
        }
    }
}
