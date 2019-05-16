using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        static Dolar()
        {
            cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad,float cotizacion)
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

        public static explicit operator Euro(Dolar d)
        {
            float auxCoti = Euro.GetCotizacion();
            double resultado = d.cantidad / auxCoti;
            Euro auxEuro = new Euro(resultado);
            return auxEuro;
        }

        public static explicit operator Peso(Dolar d)
        {
            float auxCoti = Peso.GetCotizacion();
            double resultado = d.cantidad * auxCoti;
            Peso auxPeso = new Peso(resultado);
            return auxPeso;
        }

        public static implicit operator Dolar(double d)
        {
            double cantidad = d * cotizRespectoDolar;
            Dolar auxDolar = new Dolar(cantidad);
            return auxDolar;
        }



    }
}
