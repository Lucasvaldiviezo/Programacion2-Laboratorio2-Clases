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
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            set
            {
                    clientes.Enqueue(value);
            }
            get
            {
                return clientes.Dequeue();
            }
        }

        public Negocio()
        {
            caja = new PuestoAtencion(Puesto.Caja1);
            clientes = new Queue<Cliente>();
            
        }
        public Negocio(string nombre)
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            
            bool retorno = false;
            foreach(Cliente auxCliente in n.clientes)
            {
               if(auxCliente.Numero == c.Numero)
               {
                    retorno = true;
                    break;
               }
            }
            return retorno;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {

            bool retorno = false;
            foreach (Cliente auxCliente in n.clientes)
            {
                if (auxCliente.Numero != c.Numero)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }


    }
}
