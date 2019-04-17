using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    public enum Puesto
    {
        caja1,
        caja2
    }
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;
        
        public static int NumeroActual
        {
            get
            {
                return numeroActual;
            }
        }
    }
}
