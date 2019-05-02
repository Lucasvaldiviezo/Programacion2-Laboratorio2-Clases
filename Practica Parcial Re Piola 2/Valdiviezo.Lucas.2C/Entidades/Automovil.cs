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

        public Automovil(string patente, ConsoleColor color, int valorHora) : base(patente)
        {
            this.color = color;
            Automovil.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendLine("||Automovil||");
            mostrar.AppendFormat("{0}\n Color: {1}\n Valor de Hora: {2}",base.ImprimirTicket(),color,valorHora);

        }
    }
}
