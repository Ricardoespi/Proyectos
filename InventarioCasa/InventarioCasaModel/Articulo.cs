using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioCasaModel
{
    public class Articulo
    {
        public string Nombre { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string Comprador { get; set; }//Crear Clase para esto, o buscar manera de no tener que hacer clase y tener un enum que haga la misma funcionalidad.
        public string Vendedor { get; set; }//Crear Clase para esto, o buscar manera de no tener que hacer clase y tener un enum que haga la misma funcionalidad.
        public DateTime FechaCompra { get; set; }

    }
}
