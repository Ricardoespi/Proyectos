using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioCasaModel
{
    public class Articulo
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Stock { get; set; }
        public decimal Precio { get; set; }
        public string Cliente { get; set; }//Crear Clase para esto, o buscar manera de no tener que hacer clase y tener un enum que haga la misma funcionalidad.
        public string Vendedor { get; set; }//Crear Clase para esto, o buscar manera de no tener que hacer clase y tener un enum que haga la misma funcionalidad.
        public DateTime FechaVenta { get; set; }
        public DateTime FechaCompra { get; set; }

    }
}
