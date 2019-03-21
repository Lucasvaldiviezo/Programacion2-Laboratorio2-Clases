using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 4";
            int i;
            int j;
            int limite=2;
            int contador=0;
            int suma=0;
            Console.WriteLine("Buscando numeros perfectos... ");
         
                for (i = 1; i < limite; i++)
                {
                    for (j = 1; j < i; j++)
                    {
                        if (i % j == 0 && j<i)
                        {
                            suma = suma + j;
                        }
                    }
                    if(contador<4 && suma==i)
                    {
                        contador++;
                    }else if(contador == 4)
                    {
                        break;
                    }
                    limite++;
                    Console.WriteLine("Contador: {0}",contador);
            }

            Console.ReadKey();
        }
    }
}
