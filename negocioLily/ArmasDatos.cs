using dominioLily;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace negocioLily
{
    public class ArmasDatos
    {
        public List<Armas> listar()
        {
            List<Armas> lista = new List<Armas>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setQuery("select IdArmas, Nombre from armas");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Armas aux = new Armas();
                    aux.IdArma = (int)datos.Lector["IdArmas"];
                    aux.NombreArma = (string)datos.Lector["Nombre"];
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
