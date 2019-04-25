using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;

        public string Apellido
        {
            get { return apellido; }
        }
        public int Dni
        {
            get { return dni; }
        }
        public int Edad
        {
            get { return edad; }
        }
        public string Nombre
        {
            get { return nombre; }
        }

        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
        }

        public virtual string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendFormat("||PERSONA||\nNombre: {0}\nApellido: {1}", Nombre, Apellido);
            mostrar.AppendFormat("\nDNI: {0}\nEdad: {1}", Dni, Edad);
            return mostrar.ToString();
        }

        public abstract bool ValidarAptitud();
        
    }
}
