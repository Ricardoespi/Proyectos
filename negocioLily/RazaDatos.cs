using dominioLily;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocioLily
{
    public class RazaDatos
    {
        public List<Raza> listar()
        {
			List<Raza> lista = new List<Raza>();
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.setQuery("select IdRaza, Nombre from razas;");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					Raza aux = new Raza();
					aux.IdRaza = (int)datos.Lector["IdRaza"];
					aux.NombreRaza = (string)datos.Lector["Nombre"];
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
