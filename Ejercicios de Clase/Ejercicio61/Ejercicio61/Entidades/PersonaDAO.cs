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
            consulta = String.Format("INSERT INTO dbo.Personita (Nombre,Apellido)  VALUES({0},{1})", personita.Nombre, personita.Apellido);
            comando.CommandText = consulta;
            conexion.Open();
            comando.ExecuteNonQuery();
        }

        public List<Persona> Leer()
        {
            SqlDataReader dataReader = comando.ExecuteReader();
            List<Persona> personas = new List<Persona>();
            string auxNombre;
            string auxApellido;
            int auxId;
            comando.CommandText = "SELECT ID,Nombre,Apellido FROM Personas";
            conexion.Open();
            
            
            while (dataReader.Read())
            {
                int.TryParse(dataReader["ID"].ToString(), out auxId);
                auxNombre = dataReader["Nombre"].ToString();
                auxApellido = dataReader["Apellido"].ToString();
                Persona p = new Persona(auxId, auxNombre, auxApellido);
                personas.Add(p);
            }

            return personas;
        }

        public Persona LeerPorID(int id)
        {
            string auxNombre;
            string auxApellido;
            int auxId;
            Persona p;
            comando.CommandText = String.Format("SELECT ID,Nombre,Apellido FROM Personas WHERE ID = {0}", id);
            SqlDataReader dataReader = comando.ExecuteReader();
            conexion.Open();
            if(dataReader.Read())
            {
                int.TryParse(dataReader["ID"].ToString(), out auxId);
                auxNombre = dataReader["Nombre"].ToString();
                auxApellido = dataReader["Apellido"].ToString();
                p = new Persona(auxId, auxNombre, auxApellido);
            }else
            {
                p = null;
            }
            return p;
        }

        public void Modificar(Persona personita)
        {
            String consulta;
            consulta = String.Format("UPDATE dbo.Personita SET Nombre = {0} ,Apellido = {1} WHERE ID = {2}",personita.Nombre,personita.Apellido,personita.ID);
            comando.CommandText = consulta;
            conexion.Open();
            comando.ExecuteNonQuery();
        }

        public void Borrar(int id)
        {
            String consulta;
            consulta = String.Format("DELETE FROM dbo.Personita WHERE ID = {0}", id);
            comando.CommandText = consulta;
            conexion.Open();
            comando.ExecuteNonQuery();
        }
    }
}
