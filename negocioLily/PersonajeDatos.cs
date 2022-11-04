using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using dominioLily;
using negocioLily;

namespace negocioLily
{
    public class PersonajeDatos
    {
        public List<Personaje> listar()
        {
			List<Personaje> lista = new List<Personaje>();
			AccesoDatos datos = new AccesoDatos();

			try
			{
				datos.setQuery("select Nombre, Apodo, Sexo, Raza, Clase, Armas, Magia, Historia, UrlImagen from personajes");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					Personaje aux = new Personaje();
					aux.Nombre = (string)datos.Lector["Nombre"];
					aux.Apodo = (string)datos.Lector["Apodo"];
					aux.Sexo = (string)datos.Lector["Sexo"];
					aux.Raza = (string)datos.Lector["Raza"];
					aux.Clase = (string)datos.Lector["Clase"];
					aux.Armas = (string)datos.Lector["Armas"]; 
					aux.Magia = (string)datos.Lector["Magia"];
					aux.Historia = (string)datos.Lector["Historia"];
					aux.UrlImagen = (string)datos.Lector["UrlImagen"];
					lista.Add(aux);
                }
				
				return lista;
			}
			catch (Exception ex)
			{throw ex;}
			finally
			{
				datos.cerrarConexion();
			}
        }
		public void agregar(Personaje nuevo)
		{
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.setQuery(string.Format("insert into personajes values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", nuevo.Nombre, nuevo.Apodo, nuevo.Sexo, nuevo.Raza, nuevo.Clase, nuevo.Armas, nuevo.Magia, nuevo.Historia, nuevo.UrlImagen));
				datos.ejecutarAccion();
			}
			catch (Exception ex)
			{throw ex;}
			finally { datos.cerrarConexion(); }
		}
    }
}
