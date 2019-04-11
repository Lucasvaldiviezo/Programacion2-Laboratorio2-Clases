using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Peso
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        static Peso()
        {
            cotizRespectoDolar=42.99f;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, float cotizacion)
        {
            this.cantidad = cantidad;
            cotizRespectoDolar = cotizacion;
        }

        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static explicit operator Dolar(Peso p)
        {
            float auxCoti = Peso.GetCotizacion();
            double resultado = p.cantidad / auxCoti;
            Dolar auxDolar = new Dolar(resultado);
            return auxDolar;
        }

        public static explicit operator Euro(Peso p)
        {
            Dolar auxDolar = (Dolar)p;
            float auxCoti = Euro.GetCotizacion();
            double resultado = auxDolar.GetCantidad() * auxCoti;
            Euro auxPeso = new Euro(resultado);
            return auxPeso;
        }

        public static implicit operator Peso(double d)
        {
            double cantidad = d * cotizRespectoDolar;
            Peso auxPeso = new Peso(cantidad);
            return auxPeso;
        }
    }
}
