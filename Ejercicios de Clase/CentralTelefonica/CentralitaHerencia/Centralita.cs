using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamada;
        protected string razonSocial;

        public Centralita()
        {
            listaDeLlamada = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa) : this()
        {
            razonSocial = nombreEmpresa;
        }

        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Todas);
            }

        }

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Local);
            }

        }

        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Provincial);
            }

        }

        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamada;
            }
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float retorno = 0;
            foreach (Llamada llamada in listaDeLlamada)
            {
                switch (tipo)
                {
                    case TipoLlamada.Local:
                        if (llamada is Local)
                        {
                            Local local = (Local)llamada;
                            retorno += local.CostoLlamada;
                        }
                        break;
                    case TipoLlamada.Provincial:
                        if (llamada is Provincial)
                        {
                            Provincial provincial = (Provincial)llamada;
                            retorno += provincial.CostoLlamada;
                        }
                        break;
                    case TipoLlamada.Todas:
                        if (llamada is Provincial)
                        {
                            Provincial provincial = (Provincial)llamada;
                            retorno += provincial.CostoLlamada;
                        } else if (llamada is Local)
                        {
                            Local local = (Local)llamada;
                            retorno += local.CostoLlamada;
                        }
                        break;
                }
            }
            return retorno;
        }

        protected string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendLine("******************************");
            foreach (Llamada llamada in Llamadas)
            {
                mostrar.AppendLine(llamada.ToString());
            }
            mostrar.AppendFormat("Razón Social: {0}\nGanancia por todas las llamadas: {1}\n", razonSocial, GananciasPorTotal);
            mostrar.AppendFormat("Ganancia por local: {0}\nGanancia por Provincial: {1}\n", GananciasPorLocal, GananciasPorProvincial);
            mostrar.AppendLine("******************************");
            return mostrar.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            listaDeLlamada.Add(nuevaLlamada);
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool retorno = false;
            foreach (Llamada l in c.listaDeLlamada)
            {
                if (l == llamada)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }


        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
   
            if (c != nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada);
            }else
            {
                throw new CentralitaException("La llamada ya esta en el sistema", "Centralita", "Operador +");
            }

            return c;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
