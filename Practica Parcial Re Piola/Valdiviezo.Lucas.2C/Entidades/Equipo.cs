using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        public DirectorTecnico DirectorTecnico
        {
            set { directorTecnico = value; }
        }
        public string Nombre
        {
            get { return nombre; }
        }

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static explicit operator string(Equipo e)
        {
            StringBuilder mostrar = new StringBuilder();

            mostrar.AppendFormat("|||Equipo: {0}|||", e.Nombre);
            if(e.directorTecnico != null)
            {
                mostrar.AppendFormat("\n{0}", e.directorTecnico.Mostrar());
            }else
            {
                mostrar.AppendFormat("Sin DT Asignado");
            }
            foreach (Jugador jugador in e.jugadores)
            {
                mostrar.AppendFormat("\n{0}", jugador.Mostrar());
            }

            return mostrar.ToString();
        }
    }
}
