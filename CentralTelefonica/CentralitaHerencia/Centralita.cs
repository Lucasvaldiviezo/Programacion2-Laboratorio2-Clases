using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLLamada;
        protected string razonSocial;

        public Centralita()
        {
            listaDeLLamada = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa) : this()
        {
            razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float retorno=0;
            if(tipo == TipoLlamada.Local)
            {
                foreach(Llamada llamada in listaDeLLamada)
                {
                    if(llamada is Local)
                    {
                        Local local = (Local)llamada;
                        retorno += local.CostoLlamada;
                    }
                }
            }else if(tipo == TipoLlamada.Provincial)
            {
                foreach (Llamada llamada in listaDeLLamada)
                {
                    if (llamada is Provincial)
                    {
                        Provincial provincial = (Provincial)llamada;
                        retorno += provincial.CostoLlamada;
                    }
                }
            }
            else if(tipo == TipoLlamada.Todas)
            {
                foreach (Llamada llamada in listaDeLLamada)
                {
                    if (llamada is Provincial)
                    {
                        Provincial provincial = (Provincial)llamada;
                        retorno += provincial.CostoLlamada;
                    }else if(llamada is Local)
                    {
                        Local local = (Local)llamada;
                        retorno += local.CostoLlamada;
                    }
                }
            }

            return retorno;
        }
    }
}
