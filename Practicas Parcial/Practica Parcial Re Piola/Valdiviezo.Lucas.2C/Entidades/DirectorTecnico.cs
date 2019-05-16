using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;
        public int AñosExperencia
        {
            set
            {
                añosExperiencia = value;
            }
            get
            {
                return añosExperiencia;
            }
        }

        public DirectorTecnico(string nombre,string apellido,int edad,int dni,int añosExperiencia) : base(nombre,apellido,edad,dni)
        {
            AñosExperencia = añosExperiencia;
        }

        public override string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendFormat("\n||Directo Tecnico||\n{0}\n Años de Experencian: {1}", base.Mostrar(), AñosExperencia);
            return mostrar.ToString();
        }

        public override bool ValidarAptitud()
        {
            bool retorno = false;

            if(AñosExperencia >= 2 && Edad < 65)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
