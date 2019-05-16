using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        public string Patente
        {
            set {
                    if(value.Length == 6)
                    {
                        patente = value;
                    }
                }
            get { return patente; }

        }

        public Vehiculo(string patente)
        {
            Patente = patente;
            ingreso = DateTime.Now.AddHours(-3);
        }

        public abstract string ConsultarDatos();

        public override string ToString()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendFormat(" Patente {0}", Patente);

            return mostrar.ToString();
        }

        public virtual string ImprimirTicket()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendLine("------Vehiculo------");
            mostrar.AppendFormat(" Ingreso {0}", ingreso);
            mostrar.AppendLine(this.ToString());

            return mostrar.ToString();
        }

        public static bool operator ==(Vehiculo v1,Vehiculo v2)
        {
            bool retorno = false;
            if(v1.Equals(v2) && v1.Patente == v2.Patente)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
