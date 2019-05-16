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

        public int ClientesPendientes
        {
            get
            {
                return clientes.Count();
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
               if(auxCliente == c)
               {
                    retorno = true;
                    break;
               }
            }
            return retorno;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {

            bool retorno = true;
            foreach (Cliente auxCliente in n.clientes)
            {
                if (auxCliente == c)
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;
            if(!(n == c))
            {
                n.clientes.Enqueue(c);
                retorno = true;
            }

            return retorno;
        }

        public static bool operator -(Negocio n, Cliente c)
        {
            bool retorno = false;
            if (n == c)
            {
                n.clientes.Dequeue();
                retorno = true;
            }

            return retorno;
        }

        public static bool operator ~(Negocio n)
        {
            bool retorno = false;
            if(n.caja.Atender(n.Cliente))
            {
                retorno = true;
            }
            return retorno;
        }

    }
        
}
