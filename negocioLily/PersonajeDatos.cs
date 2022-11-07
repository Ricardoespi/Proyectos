using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using dominioLily;
using System.Net;

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
				datos.setQuery("select p.Nombre, p.Apodo, p.Sexo, r.Nombre Raza, p.Clase, a.Nombre Armas, p.Magia, p.Historia, p.UrlImagen from personajes p, armas a, razas r where a.IdArmas  = p.IdArmas and p.IdRaza = r.IdRaza;");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					Personaje aux = new Personaje();
					aux.Nombre = (string)datos.Lector["Nombre"];
					aux.Apodo = (string)datos.Lector["Apodo"];
					aux.Sexo = (string)datos.Lector["Sexo"];
					aux.Raza = new Raza();
					aux.Raza.NombreRaza = (string)datos.Lector["Raza"];
					aux.Clase = (string)datos.Lector["Clase"];
					aux.Arma = new Armas();
					aux.Arma.NombreArma = (string)datos.Lector["Armas"]; 
					if (!(datos.Lector["Magia"] is DBNull))
						aux.Magia = (string)datos.Lector["Magia"];
					if (!(datos.Lector["Historia"] is DBNull))
						aux.Historia = (string)datos.Lector["Historia"];
					if (!(datos.Lector["UrlImagen"] is DBNull))
						aux.UrlImagen = (string)datos.Lector["UrlImagen"];
					lista.Add(aux);
                }
				
				return lista;
			}
			catch (Exception ex)
			{throw ex;}
			finally
			{ datos.cerrarConexion(); }
        }
		public void agregar(Personaje nuevo)
		{
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.setQuery(string.Format("insert into personajes values('{0}', '{1}', '{2}', @idRaza, '{3}', @idArma, '{4}', '{5}', '{6}')", nuevo.Nombre, nuevo.Apodo, nuevo.Sexo, nuevo.Clase, nuevo.Magia, nuevo.Historia, nuevo.UrlImagen));
				datos.setParametro("@idRaza", nuevo.Raza.IdRaza);
				datos.setParametro("@idArma", nuevo.Arma.IdArma);
				datos.ejecutarAccion();
			}
			catch (Exception ex)
			{throw ex;}
			finally { datos.cerrarConexion(); }
			
		}
    }
}
