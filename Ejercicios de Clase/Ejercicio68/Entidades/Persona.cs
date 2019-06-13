using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegadoString(string msg);
    public class Persona
    {
        private string apellido;
        private string nombre;
        public event DelegadoString EventoString;

        public Persona()
        {

        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        public string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendFormat("\nNombre: {0}, Apellido: {1}", Nombre, Apellido);
            return mostrar.ToString();
        }

        
    }
}
