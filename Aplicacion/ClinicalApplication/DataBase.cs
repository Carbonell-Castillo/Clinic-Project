using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalApplication
{
    internal class DataBase
    {   //Se crea una instancia de la clase SqlConnection para establecer la conexión a la base de datos. 
        //Este recibe un string el cual es la cadena de conexion a la base de datos a Microsft Azure
        SqlConnection connection = new SqlConnection("Server=tcp:clinica-prueba.database.windows.net,1433;Initial Catalog=clinicaDB;Persist Security Info=False;User ID=admin12;Password=admin3212*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        //Se crea una instancia de la clase SqlCommand, que se utilizará para ejecutar
        //comandos SQL en la base de datos.
        SqlCommand sqlCommand = new SqlCommand();
        // Variable de tipo System.Data.SqlClient.SqlDataReader que será utilizada
        // para almacenar los resultados de una consulta SQL
        public System.Data.SqlClient.SqlDataReader table;
        public string errorMessage;

        //Este metodo se encarga de establecer la conexion a la base de datos
        public bool Connect()
        {
            try
            {
                //Se intenta abrir la conexion por medio del metodo Open() de la instancia SqlConnect
                connection.Open();
                ConfigureCommand();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        //Establece la conexion y el tipo de comando en un objeto SqlCommand
        //Prepara el objeto para ejecutar comandos Sql
        public void ConfigureCommand()
        {
            sqlCommand.Connection = connection;
            sqlCommand.CommandType = CommandType.Text;
        }

        //Visualizar y guardar
        public bool ExecuteQuery(string procedure)
        {
            Connect();
            sqlCommand.CommandText = "exec " + procedure;
            try
            {
                table = sqlCommand.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //
        public bool ExecuteTransaction(string procedure)
        {
            Connect();
            sqlCommand.CommandText = "exec " + procedure;
            try
            {
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.ToString();
                return false;
            }
        }
    }
}
