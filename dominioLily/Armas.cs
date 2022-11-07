using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominioLily
{
    public class Armas
    {
        public int IdArma { get; set; }
        public string NombreArma{ get; set; }

        public override string ToString()
        {
            return NombreArma;
        }
    }
}
