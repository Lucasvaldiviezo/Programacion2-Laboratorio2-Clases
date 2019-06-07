using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Acces
{
    public class Base
    {
        public static String connectionStr = "Data Source=LAB3PC20\\SQLEXPRESS; Initial Catalog =AdventureWorks2012; Integrated Security = True";
        public static SqlConnection conexion;
        public static SqlCommand comando;


        public Base()
        {
            conexion = new SqlConnection(connectionStr);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public void Agregar()
        {
            String consulta;
            consulta = "INSERT INTO Purchasing.Vendor (BusinessEntityID,AccountNumber,Name,CreditRating,PreferredVendorStatus,ActiveFlag,ModifiedDate)  VALUES(1000,'300A','Pedro',4,1,0,'17/04/1990 00:00:00')";
            comando.CommandText = consulta;
            conexion.Open();
            comando.ExecuteNonQuery();
        }
        public void Modificar()
        {
            String consulta;
            consulta = "UPDATE Purchasing.Vendor SET name = 'Fer' WHERE BusinessEntityID = 1000";
            comando.CommandText = consulta;
            conexion.Open();
            comando.ExecuteNonQuery();
        }



    }
}
