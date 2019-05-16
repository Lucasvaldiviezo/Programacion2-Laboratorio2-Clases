using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresado;
            int numeroConvertido;
            int numCuadrado=0;
            int numCubo=0;
            bool validar;
            Console.Title = "Ejercicio 2";
            Console.Write("Ingrese un numero: ");
            numeroIngresado=Console.ReadLine();
            validar = int.TryParse(numeroIngresado, out numeroConvertido);

            if(validar == true)
            {
                if(numeroConvertido > 0)
                {
                    numCuadrado = (int)Math.Pow(numeroConvertido, 2);
                    numCubo = (int)Math.Pow(numeroConvertido, 3);
                }
                else
                {
                    Console.WriteLine("ERROR.¡Reingresar el numero!");
                }
            }
            Console.WriteLine("El numero ingresado es: {0}", numeroConvertido);
            Console.WriteLine("El cuadrado del numero es: {0}", numCuadrado);
            Console.WriteLine("El cubo del numero es: {0}", numCubo);
            Console.ReadKey();
        }
    }
}
