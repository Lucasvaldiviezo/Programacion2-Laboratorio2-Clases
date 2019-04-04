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

        public static string MostrarEstante(Estante e)
        {
            string cadena="";
            string codigoDeBarra;
            int i;

            cadena = "La ubicacion es: " + e.ubicacionEstante;
            for (i = 0; i < e.productos.Length; i++)
            {
                //codigoDeBarra = (string)e.productos[i];
                if(Object.ReferenceEquals(e.productos[i],null))
                {
                    cadena = cadena + "\n" + Producto.MostrarProducto(e.productos[i]);
                }
                
            }

            return cadena;
        }

        public static bool operator ==(Estante estante, Producto producto)
        {
            bool retorno = false;
            int i;
            string marcaEstante;
            string marcaProducto;

            marcaProducto = producto.GetMarca();
            for (i = 0; i < estante.productos.Length; i++)
            {
                if(!Object.ReferenceEquals(estante.productos[i],null))
                {
                    marcaEstante = estante.productos[i].GetMarca();
                    if (marcaProducto == marcaEstante)
                    {
                        retorno = true;
                        break;
                    }
                }
                    
            }
            return retorno;
        }

        public static bool operator !=(Estante estante, Producto producto)
        {
            bool retorno = false;
            int i;
            string marcaEstante;
            string marcaProducto;

            marcaProducto = producto.GetMarca();
            for (i = 0; i < estante.productos.Length; i++)
            {
                if (!Object.ReferenceEquals(estante.productos[i], null))
                {
                    marcaEstante = estante.productos[i].GetMarca();
                    if (marcaProducto != marcaEstante)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            
            return retorno;
        }

        public static bool operator +(Estante estante, Producto producto)
        {
            bool retorno=false;
            int i;
            if(!(estante==producto))
            {
                for(i=0;i<estante.productos.Length;i++)
                {
                    
                    if (Object.ReferenceEquals(estante.productos[i], null))
                    {
                        estante.productos[i] = producto;
                        retorno = true;
                        break;
                    }
                }
               
            }
            return retorno;
        }

        public static Estante operator -(Estante estante, Producto producto)
        {
            bool retorno = false;
            int i;
            if (estante == producto)
            {
                for (i = 0; i < estante.productos.Length; i++)
                {

                    if (Object.ReferenceEquals(estante.productos[i], producto))
                    {
                        estante.productos[i] = null;
                        retorno = true;
                        break;
                    }
                }

            }
            return estante;
        }

    }
}
