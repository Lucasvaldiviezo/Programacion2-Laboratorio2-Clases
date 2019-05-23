using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Contabilidad<T,U> where T : Documento 
                                   where U : Documento, new()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            egresos = new List<T>(); 
            ingresos = new List<U>();
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, T egreso)
        {
            c.egresos.Add(egreso);
            return c;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            c.ingresos.Add(ingreso);
            return c;
        }

        public string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendLine("Lista de Egresos:");
            foreach(Documento d in egresos)
            {
                mostrar.AppendFormat("-{0}\n", d.NumeroBase);
            }
            mostrar.AppendLine("-----------------------");
            mostrar.AppendLine("Lista de Ingresos:");
            foreach(Documento d in ingresos)
            {
                mostrar.AppendFormat("-{0}\n", d.NumeroBase);
            }

            return mostrar.ToString();
        }
    }
}
