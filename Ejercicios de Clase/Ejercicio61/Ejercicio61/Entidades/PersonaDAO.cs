using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class PersonaDAO
    {
        public static String connectionStr = "Data Source=LAB3PC20\\SQLEXPRESS; Initial Catalog = Persona; Integrated Security = True";
        public static SqlConnection conexion;
        public static SqlCommand comando;

        public PersonaDAO()
        {
            conexion = new SqlConnection(connectionStr);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public void Guardar(Persona personita)
        {
            String consulta;
            if(personita.ID == 0)
            {
                consulta = String.Format("INSERT INTO dbo.Personita (Nombre,Apellido)  VALUES({0},{1})", personita.Nombre, personita.Apellido);
            }
            else
            {
                consulta = String.Format("INSERT INTO dbo.Personita (ID,Nombre,Apellido)  VALUES({0},{1},{2})", personita.ID, personita.Nombre, personita.Apellido);
            }
            
            comando.CommandText = consulta;
            conexion.Open();
            comando.ExecuteNonQuery();
        }

        public void Modificar(Persona personita)
        {
            String consulta;
            consulta = String.Format("UPDATE dbo.Personita SET Nombre = {0} ,Apellido = {1} WHERE ID = {2}",personita.Nombre,personita.Apellido,personita.ID);
            comando.CommandText = consulta;
            conexion.Open();
            comando.ExecuteNonQuery();
        }
    }
}
