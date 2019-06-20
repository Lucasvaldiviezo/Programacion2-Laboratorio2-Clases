using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql : IArchivo<Queue<Patente>>
    {
        private SqlCommand comando;
        private SqlConnection conexion;

        public Sql()
        {
            conexion = new SqlConnection("Data Source = LAB3PC20\\SQLEXPRESS; Initial Catalog = patentes-sp-2018; Integrated Security = True");
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public void Guardar(string tabla, Queue<Patente> datos)
        {
            String consulta;
            conexion.Open();
            foreach (Patente p in datos)
            {
                consulta = String.Format("INSERT INTO {0} (patente,tipo)  VALUES({1},{2})", tabla, p.CodigoPatente, p.TipoCodigo);
                comando.CommandText = consulta;
                comando.ExecuteNonQuery();
            }
        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {
            datos = null;
            SqlDataReader dataReader = comando.ExecuteReader();
            string auxPatente;
            string auxTipo;
            Patente p;
            comando.CommandText = String.Format("SELECT patente,tipo FROM {0}",tabla);
            conexion.Open();
            while(dataReader.Read())
            {
                auxPatente = dataReader["patente"].ToString();
                auxTipo = dataReader["tipo"].ToString();
                if(auxTipo == "Vieja")
                {
                    p = new Patente(auxPatente, Patente.Tipo.Vieja);
                    datos.Enqueue(p);
                }
                else
                {
                    p = new Patente(auxPatente, Patente.Tipo.Mercosur);
                    datos.Enqueue(p);
                }
            }
        }
    }
}
