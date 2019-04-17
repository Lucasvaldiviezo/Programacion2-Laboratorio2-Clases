using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes = new Queue<Cliente>();
        private string nombre;

        public Cliente Cliente
        {
            set
            {
                
                if(!clientes.Contains(value))
                {
                    clientes.Enqueue(value);
                }
            }
            get
            {
                return clientes.Dequeue();
            }
        }

        public Negocio()
        {
            caja = new PuestoAtencion(Puesto.Caja1);
        }
        public Negocio(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
