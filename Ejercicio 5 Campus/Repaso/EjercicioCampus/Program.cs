﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCampus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EjercicioCampus";
            string codigoDeBarras;
            Producto producto1 = new Producto("Pepitos","123",30);
            codigoDeBarras = (string)producto1;
            string marca = "Pepitos";
            bool check;


            check = (producto1 == marca);
            if(check == true)
            {
                Console.WriteLine("Las marcas son iguales");
                
            }
            Console.WriteLine("El codigo de barra es: {0}", codigoDeBarras);

            Console.ReadKey();
        }
    }
}
