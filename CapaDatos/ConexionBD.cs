using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ConnectionToSql
    {
        private readonly string connectionString;
        private SqlConnection conexion = new SqlConnection();
        public  ConnectionToSql()
        {
            connectionString = @"Data Source =DESKTOP-JSOUI5C;Database = ProyectoENE;Trusted_Connection= True";
        }

        public SqlConnection abrirConexion()
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }
        public SqlConnection cerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }


    }
}