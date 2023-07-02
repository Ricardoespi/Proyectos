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
            Puntaje = new Dictionary<Jugador, int>();
            manos_ganadas = new Dictionary<Jugador, int>();
        }
        public Jugador Jugador_actual { get; set; }
        public Mazo Mazo { get; set; }
        public List<Jugador> Jugadores { get; set; }
        public Carta Vira { get; set; }
        public Dictionary<Jugador, int> Puntaje { get; set; }
        public Jugador ultimo_barajador { get; set; }
        public Dictionary<Jugador, int> manos_ganadas { get; set; }

        public void add_player(Jugador jugador)
        {
            Jugadores.Add(jugador);
            Puntaje[jugador] = 0;
            manos_ganadas[jugador] = 0;
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
        public void da_la_vira()
        {
            Vira = Mazo.dar_carta();
            Console.WriteLine($"La vira es {Vira.ToString()}");
        }
        public void baraja_mazo(Jugador barajador)
        {
            Mazo.Barajar();
            ultimo_barajador = barajador;
            Jugador_actual = barajador;
        }
        public void jugar_ronda()
        {
            //Play a round consisting of 3 hands
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine($"Mano {i}");
                Jugador ganador = jugar_mano();
                // Check if a player has won 2 hands and won the round
                if(ganador != null && manos_ganadas[ganador] >= 2)
                {
                    Console.WriteLine($"{ganador.Nombre} ha ganado la ronda!");
                    actualizar_puntaje(ganador);
                    break;
                }
            }
            // Reset the number of hands won by each player
            foreach (Jugador jugador in Jugadores)
            {
                manos_ganadas[jugador] = 0;
            }
            if (check_ganador())
            {
                Jugador ganador = Jugadores.First(p => Puntaje[p] >= 12);
                Console.WriteLine($"{ganador.Nombre} ha ganado el juego!");
                return;
            }
        }
        public Jugador jugar_mano()
        {
            // Play a hand
            List<Carta> cartas_jugadas = new List<Carta>();
            // Determine the order of play
            int indice_jugador_actual = Jugadores.IndexOf(Jugador_actual);
            IEnumerable<Jugador> jugadores_orden = Jugadores.Skip(indice_jugador_actual).Concat(Jugadores.Take(indice_jugador_actual));

            // Each player selects a card to play
            foreach (Jugador jugador in jugadores_orden)
            {
                Console.WriteLine(@"Que carta de tu mano quieres jugar {0}?", jugador.Nombre);
                int n = int.Parse(Console.ReadLine());
                Carta carta_jugada = jugador.seleccionar_carta(n);
                cartas_jugadas.Add(carta_jugada);
                Console.WriteLine($"{jugador.Nombre} jugo {carta_jugada.ToString()}");
            }

            // Determine the winner of the hand
            List<Carta> cartas_ganadoras = determinar_ganadoras(cartas_jugadas);
            if (cartas_ganadoras.Count == 1)
            {
                //There is a single winner
                Carta carta_ganadora = cartas_ganadoras[0];
                Jugador ganador = Jugadores.First(j => j.Mano_original.Contains(carta_ganadora));
                Console.WriteLine($"{ganador.Nombre} gano la mano con {carta_ganadora.ToString()}");
                //The current player plays first in the next hand
                Jugador_actual = ganador;
                manos_ganadas[ganador]++;
                foreach (Jugador jugador in Jugadores)
                {
                    foreach (Carta carta in cartas_jugadas)
                    {
                        if (jugador.Mano_original.Contains(carta))
                            jugador.Mano_original.Remove(carta);
                    }
                }
                return ganador;
            }
            else
            {
                Console.WriteLine("Es un empate");
                return null;
            }
            /*Carta carta_ganadora = determinar_ganador(cartas_jugadas);
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
            Jugador_actual = ganador;*/
            
        }
        private void actualizar_puntaje(Jugador ganador)
        {
            Puntaje[ganador]++;
        }
        public bool check_ganador()
        {
            foreach (Jugador jugador in Jugadores)
            {
                if (Puntaje[jugador] >= 12)
                    return true;
            }
            return false;
        }
        private List<Carta> determinar_ganadoras(List<Carta> cartas_jugadas)
        {
            // Determine the winner of a hand based on the highest card value
            List<Carta> cartas_ganadoras = new List<Carta>();
            Carta Perico = null;
            Carta Perica = null;
            if(Vira.Valor == Carta.Valores.Diez)
            {
                Perico = cartas_jugadas.FirstOrDefault(c => c.Valor == Carta.Valores.Once && c.Pinta == Vira.Pinta );
                Perica = cartas_jugadas.FirstOrDefault(c => c.Valor == Carta.Valores.Doce && c.Pinta == Vira.Pinta );
            }
            else if(Vira.Valor == Carta.Valores.Once)
            {
                Perico = cartas_jugadas.FirstOrDefault(c => c.Valor == Carta.Valores.Doce && c.Pinta == Vira.Pinta);
                Perica = cartas_jugadas.FirstOrDefault(c => c.Valor == Carta.Valores.Diez && c.Pinta == Vira.Pinta );
            }
            else
            {
                Perico = cartas_jugadas.FirstOrDefault(c => c.Valor == Carta.Valores.Once && c.Pinta == Vira.Pinta);
                Perica = cartas_jugadas.FirstOrDefault(c => c.Valor == Carta.Valores.Diez && c.Pinta == Vira.Pinta);
            }
            
            if (Perico != null)
                cartas_ganadoras.Add(Perico);
            else if (Perica != null)
                cartas_ganadoras.Add(Perica);
            else
            {
                // If no Perico or Perica cards were played, determine winner based on highest value
                var mayor_valor = cartas_jugadas.Max(c => c.Valor);
                foreach (Carta carta in cartas_jugadas)
                {
                    if(carta.Valor == mayor_valor)
                        cartas_ganadoras.Add(carta);
                }
            }
            return cartas_ganadoras;
            //Carta carta_ganadora = cartas_jugadas.OrderByDescending(c => c.Valor).First();
            //return carta_ganadora;
        }

    }
}
