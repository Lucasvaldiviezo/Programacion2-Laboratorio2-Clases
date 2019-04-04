using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCampus
{
    class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];   
        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return productos;
        }

        public string MostrarEstante(Estante e)
        {
            string cadena;
            string codigoDeBarra;
            int i;

            cadena = "La ubicacion es: " + this.ubicacionEstante;
            for (i = 0; i < productos.Length; i++)
            {
                codigoDeBarra = (string)productos[i];
                cadena = cadena + "\n" + Producto.MostrarProducto(productos[i]);
            }

            return cadena;
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;
            int i;
            string marcaEstante;
            string marcaProducto;

            marcaProducto = p.GetMarca();
            for (i = 0; i < e.productos.Length; i++)
            {
                marcaEstante = e.productos[i].GetMarca();
                if (marcaProducto == marcaEstante)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            bool retorno = false;
            int i;
            string marcaEstante;
            string marcaProducto;

            marcaProducto = p.GetMarca();
            for (i = 0; i < e.productos.Length; i++)
            {
                marcaEstante = e.productos[i].GetMarca();
                if (marcaProducto != marcaEstante)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool retorno=true;

            return retorno;
        }
        
    }
}
