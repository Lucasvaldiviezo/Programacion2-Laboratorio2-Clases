using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 12";
            string auxNumero;
            int numero;
            bool validar;
            bool validar2;
            bool continuacion = true;
            string auxConfirmacion;
            char confirmacion;
            do
            {
                Console.Write("Ingrese un numero: ");
                auxNumero = Console.ReadLine();
                validar = int.TryParse(auxNumero, out numero);
                if(validar)
                {
                    Console.Write("¿Continuar?(S/N)");
                    auxConfirmacion = Console.ReadLine();
                    validar2 = char.TryParse(auxConfirmacion, out confirmacion);
                    if (validar2)
                        continuacion = ValidarRespuesta.ValidaS_N(confirmacion);
                }else
                {
                    Console.Write("------------------");
                    Console.Write("Es no es un numero");
                    Console.Write("------------------");
                }
                
            } while (continuacion == true);
            
            Console.ReadKey();
        }
    }
}
