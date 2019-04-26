using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        public float Altura
        {
            get { return altura; }
        }
        public float Peso
        {
            get { return peso; }
        }
        public Posicion Posicion
        {
            get { return posicion; }
        }

        public Jugador(string nombre,string apellido, int edad, int dni, float peso, float altura, Posicion posicion) : base(nombre,apellido,edad,dni)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }

        public override string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();

            mostrar.AppendFormat("\n||Jugador||\n{0}\n Peso: {1}", base.Mostrar(), Peso);
            mostrar.AppendFormat("\n Altura: {0}\n Posicion: {1}", Altura, Posicion);

            return mostrar.ToString();
        }

        public bool ValidarEstadoFisico()
        {
            float IMC = Peso / (Altura * Altura);
            bool retorno=false;
            if(IMC > 18.5f && IMC <= 25)
            {
                retorno = true;
            }
            return retorno;
        }

        public override bool ValidarAptitud()
        {
            bool retorno = false;
            if(Edad < 40 && ValidarEstadoFisico())
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
