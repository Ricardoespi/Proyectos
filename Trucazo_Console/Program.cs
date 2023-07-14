using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Trucazo_Console
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Mazo mazo = new Mazo();
            Console.WriteLine(mazo.Cartas.Count);
            Juego juego = new Juego();
            //agrega a los jugadores
            juego.add_player(new Jugador("Ricardo"));
            juego.add_player(new Jugador("Carlitos"));
            //baraja el mazo
            juego.baraja_mazo(juego.Jugadores[0]);
            //vira una carta
            juego.da_la_vira();
            while (true)
            {
                juego.reparte_cartas();
                foreach (Jugador jugador in juego.Jugadores)
                {
                    jugador.Mano_original = new List<Carta>(jugador.Mano);
                }
                foreach (Jugador jugador in juego.Jugadores)
                {
                    Console.WriteLine(jugador.Nombre);
                    foreach (Carta carta in jugador.Mano)
                    {
                        Console.WriteLine(carta);
                    }
                }
                juego.jugar_ronda();
                if (juego.check_ganador())
                    break;
                Jugador siguiente_barajador = juego.Jugadores.First(p => p != juego.ultimo_barajador);
                juego.reset_mazo(siguiente_barajador);
            }
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();

        }
    }
}
