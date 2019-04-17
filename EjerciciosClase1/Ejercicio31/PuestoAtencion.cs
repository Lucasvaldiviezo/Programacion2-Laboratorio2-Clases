using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    public enum Puesto
    {
        Caja1,
        Caja2
    }
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;
        
        public static int NumeroActual
        {
            get
            {
                return numeroActual++;
            }
        }

        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cli)
        {
            bool time = false;
            System.Threading.Thread.Sleep(100);
            time = true;
            return time;
        }
    }
}
