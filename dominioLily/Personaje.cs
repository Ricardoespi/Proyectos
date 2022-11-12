using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominioLily
{
    public class Personaje
    {
        public int Id { get; set; }
        public string Nombre{ get; set; }
        public string Apodo { get; set; }
        public string Sexo { get; set; }
        public Raza Raza { get; set; }
        public Clase Clase { get; set; }
        public Armas Arma { get; set; }
        public string Magia { get; set; }
        [DisplayName("Semblanza")]
        public string Historia { get; set; }
        public string UrlImagen { get; set; }
    }
}
