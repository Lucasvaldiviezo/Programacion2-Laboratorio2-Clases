using System;
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
            Alumno alumno1 = new Alumno("Carlos", "Rodriguez", 120);
            Alumno alumno2 = new Alumno("Mario", "Fernandez", 121);
            Alumno alumno3 = new Alumno("Antonio", "Vega", 122);

            alumno1.Estudiar(1, 3);
            alumno1.Estudiar(5, 4);
            alumno1.Estudiar(6, 8);
        }
    }
}
