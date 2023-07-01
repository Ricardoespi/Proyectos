using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trucazo_Console
{
    public class Juego
    {
        public Juego() 
        { 
            Mazo = new Mazo();
            Jugadores = new List<Jugador>();
        }
        public Mazo Mazo { get; set; }
        public List<Jugador> Jugadores { get; set; }
        public void add_player(Jugador jugador)
        {
            Jugadores.Add(jugador);
        }
        public void reparte_cartas()
        {
            for (int i = 0; i < 3; i++)
            {
                foreach (Jugador jugador in Jugadores)
                {
                    Carta carta = Mazo.dar_carta();
                    if(carta != null)
                    {
                        jugador.Mano.Add(carta);
                    }
                }
            }
        }
    }
}
