using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trucazo_Console
{
    public class Jugador
    {
        public Jugador(string nombre) 
        {
            this.Nombre = nombre;
            Mano = new List<Carta>();
        }
        public string Nombre { get; set; }
        public List<Carta> Mano { get; set; }
    }
}
