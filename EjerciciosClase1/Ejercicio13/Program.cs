using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 13";
            string respuesta;
            string auxNumero;
            string auxNumeroConvertido;
            double numero;
            double numeroConvertido;
            bool validar;

            Console.WriteLine("Elija una opcion: ");
            Console.WriteLine("1)Binario a Decimal: ");
            Console.Write("2)Decimal a Binaro: ");
            respuesta = Console.ReadLine();

            if(respuesta == "1")
            {
                Console.Write("Ingrese un numero binario: ");
                auxNumero = Console.ReadLine();
                numeroConvertido = Conversor.BinarioDecimal(auxNumero);
                Console.Write("El numero en decimal es: {0} ",numeroConvertido);

            }
            else if(respuesta == "2")
            {
                Console.Write("Ingrese un numero decimal: ");
                auxNumero = Console.ReadLine();
                validar = Double.TryParse(auxNumero, out numero);
                if(validar)
                {
                    auxNumeroConvertido = Conversor.DecimalBinario(numero);
                    Console.Write("El numero en binario es: {0} ", auxNumeroConvertido);
                }
            }else
            {
                Console.Write("No existe esa opcion");
            }
            
            Console.ReadKey();
        }
    }
}
