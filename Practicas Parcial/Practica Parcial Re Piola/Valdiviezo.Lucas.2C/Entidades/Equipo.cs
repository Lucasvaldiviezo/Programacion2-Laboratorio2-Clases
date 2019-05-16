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

            mostrar.AppendFormat("|||Equipo: {0}|||\nCantidad de Jugadores: {1}", e.Nombre,cantidadMaximaJugadores);
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

        public static bool operator ==(Equipo e,Jugador j)
        {
            bool retorno = false;
            foreach(Jugador jugador in e.jugadores)
            {
                if(jugador == j)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            bool retorno = true;
            foreach (Jugador jugador in e.jugadores)
            {
                if (jugador == j)
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
           
            if(e.jugadores.Count < Equipo.cantidadMaximaJugadores && e != j && j.ValidarAptitud())
            {
                e.jugadores.Add(j);
            }

            return e;
            
        }

        public static bool ValidarEquipo(Equipo e)
        {
            bool retorno = false;
            int contArquero = 0;
            int contDefensor = 0;
            int contDelantero = 0;
            int contCentral = 0;
            
            if(e.directorTecnico != null)
            {
                foreach(Jugador jugador in e.jugadores)
                {
                    if(jugador.Posicion == Posicion.Arquero)
                    {
                        contArquero++;
                    }else if(jugador.Posicion == Posicion.Defensor)
                    {
                        contDefensor++;
                    }else if(jugador.Posicion == Posicion.Central)
                    {
                        contCentral++;
                    }else if(jugador.Posicion == Posicion.Delantero)
                    {
                        contDelantero++;
                    }
                }
                
                if(e.jugadores.Count == cantidadMaximaJugadores && contArquero == 1 && contCentral>0 && contDefensor>0 && contDelantero>0)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

    }
}
