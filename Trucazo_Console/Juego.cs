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
        public Jugador Jugador_actual { get; set; }
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
                        jugador.Mano_original.Add(carta);
                    }
                }
            }
        }
        public void jugar_mano()
        {
            // Play a hand
            List<Carta> cartas_jugadas = new List<Carta>();

            // Each player selects a card to play
            foreach (Jugador jugador in Jugadores)
            {
                Console.WriteLine(@"Que carta de tu mano quieres jugar {0}?", jugador.Nombre);
                int n = int.Parse(Console.ReadLine());
                Carta carta_jugada = jugador.seleccionar_carta(n);
                cartas_jugadas.Add(carta_jugada);
                Console.WriteLine($"{jugador.Nombre} jugo {carta_jugada.ToString()}");
            }

            // Determine the winner of the hand
            Carta carta_ganadora = determinar_ganador(cartas_jugadas);
            Jugador ganador = null;
            foreach (Jugador jugador in Jugadores)
            {
                if (jugador.Mano_original.Contains(carta_ganadora))
                {
                    ganador = jugador;
                }
            }
            //Jugador ganador = Jugadores.First(p => p.Mano.Contains(carta_ganadora));
            Console.WriteLine($"{ganador.Nombre} gano la mano con {carta_ganadora.ToString()}");

            // The winner plays first in the next hand
            Jugador_actual = ganador;
            foreach (Jugador jugador in Jugadores)
            {
                foreach (Carta carta in cartas_jugadas)
                {
                    if (jugador.Mano_original.Contains(carta)) 
                        jugador.Mano_original.Remove(carta);
                }
            }
        }
        private Carta determinar_ganador(List<Carta> cartas_jugadas)
        {
            // Determine the winner of a hand based on the highest card value
            Carta carta_ganadora = cartas_jugadas.OrderByDescending(c => c.Valor).First();
            return carta_ganadora;
        }

    }
}
