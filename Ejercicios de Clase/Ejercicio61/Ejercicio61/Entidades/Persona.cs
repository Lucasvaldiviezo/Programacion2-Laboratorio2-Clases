using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;

        public Persona(string nombre, string apellido) : this(0,nombre,apellido)
        {

        }
        public Persona(int id, string nombre, string apellido)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}
