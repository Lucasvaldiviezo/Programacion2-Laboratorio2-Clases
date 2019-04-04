using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCampus
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca,string codigo,float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        public string GetMarca()
        {
            string marca;
            marca = this.marca;
            return marca;
        }

        public float GetPrecio()
        {
            float precio;
            precio = this.precio;
            return precio;
        }

        public static string MostrarProducto(Producto p)
        {
            string cadena = "";
            if(!Object.ReferenceEquals(p,null))
            {
                cadena = "La marca es " + p.marca + "\nEl codigo de barra es " + p.codigoDeBarra + "\nEl precio es " + p.precio;
            }
            
            return cadena;
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool retorno = false;
            if(p1.marca == p2.marca && 
               p1.codigoDeBarra == p2.codigoDeBarra)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            bool retorno = false;
            if (p1.marca != p2.marca ||
               p1.codigoDeBarra != p2.codigoDeBarra)
            {
                retorno = true;
            }
            //return !(p1 == p2);
            return retorno;
        }

        public static bool operator ==(Producto p, string marca)
        {
            bool retorno = false;
            if (p.marca == marca )
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Producto p, string marca)
        {
            bool retorno = false;
            if (p.marca != marca)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
