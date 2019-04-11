using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        static Euro()
        {
            cotizRespectoDolar = 1.13f;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion)
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

        public static explicit operator Dolar(Euro e)
        {
            float auxCoti = Euro.GetCotizacion();
            double resultado = e.cantidad / auxCoti;
            Dolar auxDolar = new Dolar(resultado);
            return auxDolar;
        }

        public static explicit operator Peso(Euro e)
        {
            Dolar auxDolar = (Dolar)e;
            float auxCoti = Peso.GetCotizacion();
            double resultado = auxDolar.GetCantidad() * auxCoti;
            Peso auxPeso = new Peso(resultado);
            return auxPeso;
        }

        public static implicit operator Euro(double d)
        {
            double cantidad = d * cotizRespectoDolar;
            Euro auxEuro = new Euro(cantidad);
            return auxEuro;
        }

    }
}
