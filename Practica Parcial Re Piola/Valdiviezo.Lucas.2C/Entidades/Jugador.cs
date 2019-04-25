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

            mostrar.AppendFormat("||Jugador||\n{0}\nPeso: {1}", base.Mostrar(), Peso);
            mostrar.AppendFormat("\nAltura: {0}\nPosicion: {1}", Altura, Posicion);

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
    }
}
