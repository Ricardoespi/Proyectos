using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LilypadsPersonajes
{
    internal class PersonajeDatos
    {
        public List<Personaje> listar()
        {
			List<Personaje> lista = new List<Personaje>();
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;

			try
			{
				conexion.ConnectionString = "server=.\\SQLEXPRESS; database=LilypadsDB; integrated security=true;";
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select Nombre, Apodo, Sexo, Raza, Clase, Armas, Magia, Historia, UrlImagen from personajes\r\n";
				comando.Connection = conexion;
				conexion.Open();
				lector = comando.ExecuteReader();
				while (lector.Read())
				{
					Personaje aux = new Personaje();
					aux.Nombre = (string)lector["Nombre"];
					aux.Apodo = (string)lector["Apodo"];
					aux.Sexo = (string)lector["Sexo"];
					aux.Raza = (string)lector["Raza"];
					aux.Clase = (string)lector["Clase"];
					aux.Armas = (string)lector["Armas"]; 
					aux.Magia = (string)lector["Magia"];
					aux.Historia = (string)lector["Historia"];
					aux.UrlImagen = (string)lector["UrlImagen"];
					lista.Add(aux);
                }
				conexion.Close();
				return lista;
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }
    }
}
