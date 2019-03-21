using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresado;
            int numeroConvertido;
            bool validar;
            int i;
            int j;
            int contador=0;
            Console.Title = "Ejercicio 3";
            Console.Write("Ingrese un numero: ");
            numeroIngresado = Console.ReadLine();
            validar = int.TryParse(numeroIngresado, out numeroConvertido);

            if(validar)
            {
                for(i=1;i<=numeroConvertido;i++)
                {
                    for(j=1;j<=i;j++)
                    {
                        if ((i % j) == 0 && contador < 3)
                        {
                            contador++;
                        }
                    }
                    if(contador==2)
                    {
                        Console.WriteLine("El numero {0} es primo", i);
                        contador = 0;
                    }else
                    {
                        contador = 0;
                    }
                    
                }

            }
            Console.ReadKey();
        }
    }
}
