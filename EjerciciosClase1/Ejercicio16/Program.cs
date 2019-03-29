using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto1;
            string texto2;
            string texto3;
            Console.Title = "Ejercicio 16";
            Alumno alumno1 = new Alumno("Carlos", "Rodriguez", 120);
            Alumno alumno2 = new Alumno("Mario", "Fernandez", 121);
            Alumno alumno3 = new Alumno("Antonio", "Vega", 122);
            alumno1.Estudiar(1, 3);
            alumno2.Estudiar(5, 4);
            alumno3.Estudiar(6, 8);
            alumno1.CalcularFinal();
            Thread.Sleep(100);
            alumno2.CalcularFinal();
            Thread.Sleep(100);
            alumno3.CalcularFinal();
            texto1 = alumno1.Mostrar();
            texto2 = alumno2.Mostrar();
            texto3 = alumno3.Mostrar();
            Console.WriteLine("-----------");
            Console.WriteLine("{0}",texto1);
            Console.WriteLine("-----------");
            Console.WriteLine("{0}",texto2);
            Console.WriteLine("-----------");
            Console.WriteLine("{0}",texto3);
            Console.WriteLine("-----------");
            Console.ReadKey();
        }
    }
}
