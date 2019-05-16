using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        public override bool Equals(object obj)
        {
            return obj is Automovil;
        }

        private ConsoleColor color;
        private static int valorHora;

        static Automovil()
        {
            valorHora = 50;
        }

        public Automovil(string patente,ConsoleColor color) : base(patente)
        {
            this.color = color;
        }

        public Automovil(string patente, ConsoleColor color, int valorHora) : this(patente,color)
        {
            Automovil.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendLine("||Automovil||");
            mostrar.AppendLine(base.ImprimirTicket());
            mostrar.AppendFormat(" Color: {0}\n Valor de Hora: {1}",color,valorHora);
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
