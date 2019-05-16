using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public abstract float CostoLlamada
        {
            get;
        }

        public float Duracion
        {
            get
            {
                return duracion;
            }  
        }
        public string NroDestino
        {
            get
            {
                return nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return nroOrigen;
            }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        protected virtual string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendFormat("Numero Origen: {0}\nNumero Destino: {1}\nDuracion: {2}\n",NroOrigen,NroDestino,Duracion);
            return mostrar.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;
            if(llamada1.duracion > llamada2.duracion)
            {
                retorno = 1;
            }else if(llamada1.duracion < llamada2.duracion)
            {
                retorno = -1;
            }

            return retorno;
        }

        public static bool operator ==(Llamada llamada1, Llamada llamada2)
        {
            bool retorno = false;
            if(llamada1.Equals(llamada2) && 
               llamada1.NroOrigen == llamada2.NroOrigen && 
               llamada1.NroDestino == llamada2.NroDestino)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Llamada llamada1, Llamada llamada2)
        {
            return !(llamada1 == llamada2);
        }

        
    }

}
