using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 19";
            Sumador suma = new Sumador(4);
            Sumador suma2 = new Sumador(5);
            long numero1 = 2;
            long numero2 = 3;
            long resultado;
            string mensaje1 = "Hola";
            string mensaje2 = " y Chau";
            string cadena;
            int totalSumas;
            long totalCantSumas;
            bool cantSumasIguales;
            resultado = suma.Sumar(numero1, numero2);
            cadena = suma.Sumar(mensaje1, mensaje2);
            totalSumas = (int)suma;
            totalCantSumas = suma + suma2;
            cantSumasIguales = suma | suma2;
            Console.WriteLine("El resultado de la suma es: {0}", resultado);
            Console.WriteLine("El mensaje es: {0}", cadena);
            Console.WriteLine("El total de sumas es: {0}", totalSumas);
            Console.WriteLine("El total de la cantidad de sumas es: {0}", totalCantSumas);
            if(cantSumasIguales)
            {
                Console.WriteLine("El cantidad de sumas son iguales");
            }else
            {
                Console.WriteLine("El cantidad de sumas no son iguales");
            }
            
            Console.ReadKey();
        }
    }
}
