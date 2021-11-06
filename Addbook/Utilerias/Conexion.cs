using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Addbook.Utilerias
{
    class Conexion
    {
        public static int ejecutarSentencia(string sentencia, CommandType tipo, List<SqlParameter> parametros = null)
        {
            int filasAfectadas = -1;
            SqlConnection con = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
        
                con.ConnectionString = ("Server=MAHO\\SQLEXPRESS; database=Biblioteca;integrated security=true");
                con.Open();
                comando.Connection = con;
                comando.CommandType = tipo;
                comando.CommandText = sentencia;
                if (parametros != null)
                {
                    comando.Parameters.AddRange(parametros.ToArray());
                }
                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return filasAfectadas;
        }//Metodo ejecutar sentencias
        public static DataTable ejecutarSelect(string sentencia, CommandType tipo, List<SqlParameter> parametros = null)
        {

            SqlConnection con = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            DataTable datos = new DataTable();
            try
            {
                con.ConnectionString = ("Server=MAHO\\SQLEXPRESS; database=Biblioteca;integrated security=true");
                con.Open();
                comando.Connection = con;
                comando.CommandType = tipo;
                comando.CommandText = sentencia;
                if (parametros != null)
                {
                    comando.Parameters.AddRange(parametros.ToArray());
                }
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return datos;
        }//Metodo ejecutar Select

    }
}
