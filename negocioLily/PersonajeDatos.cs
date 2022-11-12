using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using dominioLily;
using System.Net;
using System.Reflection;

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
				datos.setQuery("select p.Id, p.Nombre, p.Apodo, p.Sexo, p.IdRaza, r.Nombre Raza, p.IdClase, c.Nombre Clase, p.IdArmas, a.Nombre Armas, p.Magia, p.Historia, p.UrlImagen from personajes p, armas a, razas r, clases c where a.IdArmas  = p.IdArmas and p.IdRaza = r.IdRaza and p.IdClase = c.IdClase and p.Activo = 1");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					Personaje aux = new Personaje();
					aux.Id = (int)datos.Lector["Id"];
					aux.Nombre = (string)datos.Lector["Nombre"];
					aux.Apodo = (string)datos.Lector["Apodo"];
					aux.Sexo = (string)datos.Lector["Sexo"];
					aux.Raza = new Raza();
					aux.Raza.IdRaza = (int)datos.Lector["IdRaza"];
					aux.Raza.NombreRaza = (string)datos.Lector["Raza"];
					aux.Clase = new Clase();
					aux.Clase.IdClase = (int)datos.Lector["IdClase"];
					aux.Clase.NombreClase = (string)datos.Lector["Clase"];
					aux.Arma = new Armas();
					aux.Arma.IdArma = (int)datos.Lector["IdArmas"];
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
				datos.setQuery("insert into personajes(Nombre, Apodo, Sexo, IdRaza, IdClase, IdArmas, Magia, Historia, UrlImagen) values (@nombre, @apodo, @sexo, @idRaza, @idClase, @idArma, @magia, @historia, @img)");
				datos.setParametro("@nombre", nuevo.Nombre);
				datos.setParametro("@apodo", nuevo.Apodo);
				datos.setParametro("@sexo", nuevo.Sexo);
				datos.setParametro("@magia", nuevo.Magia);
				datos.setParametro("@historia", nuevo.Historia);
				datos.setParametro("@img", nuevo.UrlImagen);
                datos.setParametro("@idRaza", nuevo.Raza.IdRaza);
				datos.setParametro("@idArma", nuevo.Arma.IdArma);
				datos.setParametro("@idClase", nuevo.Clase.IdClase);
				datos.ejecutarAccion();
			}
			catch (Exception ex)
			{throw ex;}
			finally { datos.cerrarConexion(); }
			
		}
		public void modificar(Personaje pj)
		{
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.setQuery("update personajes set Nombre = @nombre, Apodo = @apodo, Sexo = @sexo, IdRaza = @idRaza, IdClase = @idClase, IdArmas = @idArmas, Magia = @magia, Historia = @historia, UrlImagen = @img where id = @id;");
				datos.setParametro("@nombre", pj.Nombre);
				datos.setParametro("@apodo", pj.Apodo);
				datos.setParametro("@sexo", pj.Sexo);
				datos.setParametro("@idRaza", pj.Raza.IdRaza);
				datos.setParametro("@idClase", pj.Clase.IdClase);
				datos.setParametro("@idArmas", pj.Arma.IdArma);
				datos.setParametro("@magia", pj.Magia);
				datos.setParametro("@historia", pj.Historia);
				datos.setParametro("@img", pj.UrlImagen);
				datos.setParametro("@id", pj.Id);
                datos.ejecutarAccion();
            }
			catch (Exception ex)
			{ throw ex; }
			finally
			{
				datos.cerrarConexion();
			}
		}
		public void eliminar(int id)
		{
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.setQuery("delete from personajes where id = @id");
				datos.setParametro("@id", id);
				datos.ejecutarAccion();
			}
			catch (Exception ex)
			{ throw ex; }
			finally
			{
				datos.cerrarConexion();
			}
		}
		public void eliminarLogico(int id)
		{
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.setQuery("update personajes set Activo = 0 where id = @id");
				datos.setParametro("@id", id);
				datos.ejecutarAccion();
			}
			catch (Exception ex)
			{ throw ex; }
			finally
			{
				datos.cerrarConexion();
			}
		}

        public List<Personaje> filtrar(string campo, string criterio, string filtro)
        {
			List<Personaje> lista = new List<Personaje>();
			AccesoDatos datos = new AccesoDatos();
			try
			{
				string consulta = "select p.Id, p.Nombre, p.Apodo, p.Sexo, p.IdRaza, r.Nombre Raza, p.IdClase, c.Nombre Clase, p.IdArmas, a.Nombre Armas, p.Magia, p.Historia, p.UrlImagen from personajes p, armas a, razas r, clases c where a.IdArmas  = p.IdArmas and p.IdRaza = r.IdRaza and p.IdClase = c.IdClase and p.Activo = 1 ";
				if (campo == "Raza")
					consulta += "and r.Nombre";
				else if (campo == "Clase")
					consulta += "and c.Nombre";
				else if (campo == "Armas")
					consulta += "and a.Nombre";
				else
					consulta += "and p." + campo;
				consulta += " like '";
				switch (criterio)
				{
					case "Contiene":
						consulta += "%" + filtro + "%'";
						break;
					case "Empieza con":
						consulta += filtro + "%'";
						break;
					default:
						consulta += "%" + filtro + "'";
						break;
				}
				datos.setQuery(consulta);
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
                    Personaje aux = new Personaje();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Apodo = (string)datos.Lector["Apodo"];
                    aux.Sexo = (string)datos.Lector["Sexo"];
                    aux.Raza = new Raza();
                    aux.Raza.IdRaza = (int)datos.Lector["IdRaza"];
                    aux.Raza.NombreRaza = (string)datos.Lector["Raza"];
                    aux.Clase = new Clase();
                    aux.Clase.IdClase = (int)datos.Lector["IdClase"];
                    aux.Clase.NombreClase = (string)datos.Lector["Clase"];
                    aux.Arma = new Armas();
                    aux.Arma.IdArma = (int)datos.Lector["IdArmas"];
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
			{ throw ex; }
			finally
			{
				datos.cerrarConexion();
			}
        }
    }
}
