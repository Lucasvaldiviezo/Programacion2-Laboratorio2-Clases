using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        public override bool Equals(object obj)
        {
            return obj is Moto;
        }

        private int cilindrada;
        private short ruedas;
        private static int valorHora;

        static Moto()
        {
            valorHora = 30;
            ruedas = 2;
        }
        public Moto(string patente,int cilindrada) : base(patente)
        {
            this.cilindrada = cilindrada;
            
        }
        public Moto(string patente,int cilindrada,short ruedas) : this(patente,cilindrada)
        {
            this.ruedas = ruedas;
        }

        public Moto(string patente,int cilindrada,short ruedas,int valorHora) : this(patente,cilindrada,ruedas)
        {
            Moto.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendLine("||Moto||");
            mostrar.AppendLine(base.ImprimirTicket());
            mostrar.AppendFormat(" Cilindrada: {0}\n Ruedas: {1}\n Valor de Hora: {2}", cilindrada,ruedas, valorHora);
            return mostrar.ToString();
        }

        public override string ImprimirTicket()
        {
            int costoEstadia;
            StringBuilder mostrar = new StringBuilder();
            costoEstadia = valorHora * ingreso.Hour;
            mostrar.AppendLine(ConsultarDatos());
            mostrar.AppendFormat(" Costo de Estadia: {0}", costoEstadia);
            return mostrar.ToString();
        }
    }
}
