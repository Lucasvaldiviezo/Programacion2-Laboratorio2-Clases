using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public string nombre;
        public int legajo;

        public Alumno(string nombreAlumno, string apellidoAlumno, int legajoAlumno)
        {
            nombre = nombreAlumno;
            apellido = apellidoAlumno;
            legajo = legajoAlumno;
        }
        /// <summary>
        /// Recibe 2 notas y las agrega al alumno instanciado.
        /// </summary>
        /// <param name="nota1Alumno"></param>
        /// <param name="nota2Alumno"></param>
        public void Estudiar(byte nota1Alumno, byte nota2Alumno)
        {
            nota1 = nota1Alumno;
            nota2 = nota2Alumno;
        }

        public void CalcularFinal()
        {
          if(nota1 < 4 && nota2 < 4)
          {
                notaFinal = -1;
          }else
          {
                Random auxFinal = new Random();
                notaFinal = auxFinal.Next(4,10);   
          }
        }

}

}
