using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominioLily
{
    public class Clase
    {
        public int IdClase { get; set; }
        public string NombreClase { get; set; }
        public override string ToString()
        {
            return NombreClase;
        }
    }
}
