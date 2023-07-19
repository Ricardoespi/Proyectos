using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            Mano_original= new List<Carta>();
        }
        public string Nombre { get; set; }
        public List<Carta> Mano { get; set; }
        public List<Carta> Mano_original { get; set; }
        public Carta seleccionar_carta()
        {
            Carta carta_seleccionada = Mano.First();
            Mano.Remove(carta_seleccionada);
            return carta_seleccionada;
        }
        public Carta seleccionar_carta(int indice_carta)
        {
            Carta carta_seleccionada = Mano[indice_carta-1];
            Mano.RemoveAt(indice_carta-1);
            return carta_seleccionada;
        }
    }
}
