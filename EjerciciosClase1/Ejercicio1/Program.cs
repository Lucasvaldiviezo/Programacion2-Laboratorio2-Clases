using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresado;
            int numConvertido;
            bool verificar;
            int i;
            int suma=0;
            int maximo=int.MinValue;
            int minimo=int.MaxValue;
            int salida;
            float promedio;
            Console.Title = "Ejercicio 1";

            for(i=0;i<5;i++)
            {
                Console.WriteLine(" ");
                Console.Write("Ingrese numero {0}: ", i);
                numeroIngresado = Console.ReadLine();
                verificar = int.TryParse(numeroIngresado,out numConvertido);
                
                if(verificar==true)
                {
                    Console.WriteLine("El numero ingresado es: {0}", numConvertido);
                    if (numConvertido > maximo)
                    {
                        maximo = numConvertido;
                    }
                    if (numConvertido < minimo)
                    {
                        minimo = numConvertido;
                    }
                    suma = suma + numConvertido;
                    
                }
               
            }
            Console.Clear();
            promedio = suma /i;
            Console.WriteLine("El promedio es: {0}", promedio);
            Console.WriteLine("El maximo es: {0}", maximo);
            Console.WriteLine("El minimo es: {0}", minimo);
            Console.ReadKey();
        }
    }
}
