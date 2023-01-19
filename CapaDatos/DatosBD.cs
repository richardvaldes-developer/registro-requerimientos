using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CapaDeDatos : ConnectionToSql
    {
        DataTable tablaVirtual = new DataTable();
        /*SqlCommand cmd = new SqlCommand();*/


        //metodo que retorna el administrador login y contraseña
        public bool Login(string Administrador, string contraseña)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Administrador where " +
                        "Administrador=@Administrador and contraseña=@contraseña";
                    command.Parameters.AddWithValue("@Administrador", Administrador);
                    command.Parameters.AddWithValue("@contraseña", contraseña);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserCache.Administrador = reader.GetInt32(0);
                            UserCache.contraseña = reader.GetString(1);

                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        //metodo para ingresar datos a sql server
        public void InsertarDatosABaseDeDatos(string TipoRequerimiento, string Userasign, 
            string DescripcionRequerimiento,string Prioridad,int Diasplazo)
        {
            using (var connection = GetConnection())
            {
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection= connection;
                    command.CommandType= CommandType.Text;
                    command.CommandText = 
                        "INSERT INTO requerimiento (TipoRequerimiento, UsuarioAsignado, " +
                             "DescripcionRequerimiento, Prioridad,Diasplazo) " +
                                "VALUES('"+ TipoRequerimiento + "', '"+ Userasign + "','"
                                    + DescripcionRequerimiento + "','"+ Prioridad + "','"
                                        + Diasplazo+"'); ";
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    }

}

