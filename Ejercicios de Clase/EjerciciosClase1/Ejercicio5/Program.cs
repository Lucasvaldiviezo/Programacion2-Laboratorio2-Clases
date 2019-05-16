using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresado;
            int numeroConvertido;
            int auxNumero;
            bool validar;
            int i;
            int suma=0;
            int suma2 = 0;
            Console.Title = "Ejercicio 5";
            Console.Write("Ingrese su centro numerico: ");
            numeroIngresado = Console.ReadLine();
            validar = int.TryParse(numeroIngresado, out numeroConvertido);
            for(i=1;i<numeroConvertido;i++)
            {
                suma = suma + i;
            }
            suma2 = numeroConvertido + 1;
            auxNumero = numeroConvertido + 1;
            do
            {
                auxNumero++;
                suma2 = suma2 + auxNumero;
                
            }while (suma2 < suma);

            if(suma2==suma)
            {
                Console.WriteLine("El numero {0} es un centro numerico", numeroConvertido);
                Console.WriteLine("La primera suma es: {0} y la segunda es: {0} ", suma,suma2);
            }
            else
            {
                Console.WriteLine("El numero {0} no es un centro numerico", numeroConvertido);
                Console.WriteLine("La primera suma es: {0} y la segunda es: {0} ", suma, suma2);
            }
            
            Console.ReadKey();
        }
    }
}
