using dominioLily;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocioLily
{
    public class ClaseConexion
    {
        public List<Clase> listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Clase> lista = new List<Clase>();
            try
            {
                datos.setQuery("select IdClase, Nombre from clases");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Clase aux = new Clase();
                    aux.IdClase = (int)datos.Lector["IdClase"];
                    aux.NombreClase = (string)datos.Lector["Nombre"];
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
