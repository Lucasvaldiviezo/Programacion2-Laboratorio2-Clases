﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLLamada;
        protected string razonSocial;

        public Centralita()
        {
            listaDeLLamada = new List<Llamada>();

        }
    }
}
