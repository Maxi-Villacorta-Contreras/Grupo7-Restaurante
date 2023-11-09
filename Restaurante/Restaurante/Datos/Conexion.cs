using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Restaurante.Datos
{
    internal class Conexion
    {
        private static string servidor = "127.0.0.1";
        private static string usuario = "root";
        private static string password = "";
        private static string baseDatos = "Restaurante";

        private static string cadenaConexion = "Server=" + servidor + ";Database=" + baseDatos + ";Uid=" + usuario + ";Pwd=" + password + "";
        private MySqlConnection conn;
        public Conexion()
        {
        }
        public MySqlConnection GetConnection()
        { 
            if (conn == null)
             {
                try
                  {
                     conn = new MySqlConnection(cadenaConexion);
                     conn.Open();
                  }
               catch (MySqlException error)
               {
                   // vamos a crear una clase donde guarde el error en un archivo
                   throw;
                }      
            }
            return conn;
        }


        public ConnectionState estadoConexion()
        {
                return conn.State;
        }


        public void setConexion()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

        }
    }

}
