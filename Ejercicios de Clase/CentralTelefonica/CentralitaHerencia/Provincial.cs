﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }
        protected Franja franjaHoraria;

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen,Franja miFranja,float duracion,string destino) : base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
        }

        private float CalcularCosto()
        {
            float retorno=0;
            if(franjaHoraria == Franja.Franja_1)
            {
                retorno = duracion * 0.99f;
            }else if(franjaHoraria == Franja.Franja_2)
            {
                retorno = duracion * 1.25f;
            }else if(franjaHoraria == Franja.Franja_3)
            {
                retorno = duracion * 0.66f;
            }
            return retorno;
        }

        protected override string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendFormat("{0}\nEl costo es: {1}\nLa franja es: {2}", base.Mostrar(),CostoLlamada,franjaHoraria);
            return mostrar.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
