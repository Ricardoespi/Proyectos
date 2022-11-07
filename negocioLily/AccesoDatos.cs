using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocioLily
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public AccesoDatos()
        {
            comando = new SqlCommand();
            conexion = new SqlConnection(); 
            conexion.ConnectionString = "server=.\\SQLEXPRESS; database=LilypadsDB; integrated security=true;";
        }

        public void setQuery(string consulta)
        {
            try
            {
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = consulta;
            }
            catch (Exception ex)
            {throw ex;}
        }
        public void setParametro(string nombre, object valor)
        {
            try
            {
                comando.Parameters.AddWithValue(nombre, valor);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public void ejecutarLectura()
        {
            try
            {
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch ( Exception ex)
            {throw ex;}
        }
        public void ejecutarAccion()
        {
            try
            {
                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {throw ex;}
        }
        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }
    }
}
