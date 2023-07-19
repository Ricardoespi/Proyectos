using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Trucazo_Console.Carta;

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
        public List<Jugador> Jugadores { get; set; }
        public Mazo Mazo { get; set; }
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
                    if (carta != null)
                        jugador.Mano.Add(carta);
                    jugador.Mano = determinar_perico(jugador.Mano);
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
            Jugador_actual = Jugadores.First(j => j !=barajador);
        }
        public void reset_mazo(Jugador barajador)
        {
            Mazo = new Mazo();
            baraja_mazo(barajador);
            da_la_vira();
            foreach (Jugador jugador in Jugadores)
            {
                jugador.Mano.Clear();
                jugador.Mano_original.Clear();
            }
        }
        public void jugar_ronda(Jugador mano)
        {
            Jugador ganador_primera_mano = null;
            //Play a round consisting of 3 hands
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine($"Mano {i}");
                Jugador ganador = jugar_mano();
                if (i == 1 && ganador != null)
                    ganador_primera_mano = ganador;
                // Check if a player has won 2 hands and won the round
                if (i == 2 && ganador == null)
                {
                    ganador = ganador_primera_mano;
                    manos_ganadas[ganador_primera_mano]++;
                }
                if (ganador != null && manos_ganadas[ganador] >= 2)
                {
                    Console.WriteLine($"{ganador.Nombre} ha ganado la ronda!");
                    actualizar_puntaje(ganador);
                    break;
                }
                
                // Check if there was a tie in the first hand
                if (i == 1 && ganador == null)
                {
                    // Skip the second hand and go directly to the third hand
                    Console.WriteLine("Cartas paldas, se pasa directamente a tercera.");
                    i++;
                }
                if (i == 3 && ganador == null)
                {
                    //Retroceder a la segunda mano para ver que carta es mayor.
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
            jugar_envido(mano);
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
                jugador.Mano = determinar_perico(jugador.Mano);
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
                return ganador;
            }
            else
            {
                Console.WriteLine("Es un empate");
                return null;
            }
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
        public List<Carta> determinar_perico(List<Carta> cartas_jugadas)
        {
            Carta Perico = null;
            Carta Perica = null;
            if (Vira.Valor == Carta.Valores.Diez)
            {
                Perico = cartas_jugadas.FirstOrDefault(c => c.Valor == Carta.Valores.Once && c.Pinta == Vira.Pinta);
                Perica = cartas_jugadas.FirstOrDefault(c => c.Valor == Carta.Valores.Doce && c.Pinta == Vira.Pinta);
            }
            else if (Vira.Valor == Carta.Valores.Once)
            {
                Perico = cartas_jugadas.FirstOrDefault(c => c.Valor == Carta.Valores.Doce && c.Pinta == Vira.Pinta);
                Perica = cartas_jugadas.FirstOrDefault(c => c.Valor == Carta.Valores.Diez && c.Pinta == Vira.Pinta);
            }
            else
            {
                Perico = cartas_jugadas.FirstOrDefault(c => c.Valor == Carta.Valores.Once && c.Pinta == Vira.Pinta);
                Perica = cartas_jugadas.FirstOrDefault(c => c.Valor == Carta.Valores.Diez && c.Pinta == Vira.Pinta);
            }

            if (Perico != null)
            {
                Perico.Valor = Valores.Perico;
                Perico.Valor_envido = Valores_envido.Perico;
            }
            else if (Perica != null)
            {
                Perica.Valor = Valores.Perica;
                Perica.Valor_envido = Valores_envido.Perica;
            }
            return cartas_jugadas;
        }
        private List<Carta> determinar_ganadoras(List<Carta> cartas_jugadas)
        {
            // Determine the winner of a hand based on the highest card value
            List<Carta> cartas_ganadoras = new List<Carta>();
            // If no Perico or Perica cards were played, determine winner based on highest value
            cartas_jugadas = determinar_perico(cartas_jugadas);
            var mayor_valor = cartas_jugadas.Max(c => c.Valor);
            foreach (Carta carta in cartas_jugadas)
            {
                if (carta.Valor == mayor_valor)
                    cartas_ganadoras.Add(carta);
            }
            
            return cartas_ganadoras;
        }
        public void jugar_envido(Jugador mano)
        {
            Console.WriteLine("Jugando envido");
            Jugador ganador = null;
            Dictionary<Jugador, int> puntaje_envido = new Dictionary<Jugador, int>();
            foreach (Jugador jugador in Jugadores)
            {
                puntaje_envido[jugador] = calcular_puntaje_envido(jugador);
                Console.WriteLine($"El envido de {jugador.Nombre} es {puntaje_envido[jugador]}");
            }
            if (puntaje_envido[Jugadores[0]] == puntaje_envido[Jugadores[1]])
            {
                ganador = mano;
            }
            else
            {
                ganador = puntaje_envido.OrderByDescending(j => j.Value).First().Key;
            }
            Console.WriteLine($"{ganador.Nombre} gano el envido \n");
            Console.WriteLine(new string('*', 120 ) + "\n");
            actualizar_puntaje(ganador);
        }
        public void flor_envido(Jugador mano)
        {
            bool flor = false;
            foreach (Jugador jugador in Jugadores)
            {
                if (jugador.Mano_original.All(c => c.Pinta == jugador.Mano_original[0].Pinta))
                {
                    Console.WriteLine($"{jugador.Nombre} tiene flor!");
                    flor = true;
                }
            }
            if (!flor)
                jugar_envido(mano);
        }
        private int calcular_puntaje_envido(Jugador jugador)
        {
            Carta Perico = jugador.Mano_original.FirstOrDefault(c => c.Valor == (Valores)16 && c.Pinta == Vira.Pinta);
            Carta Perica = jugador.Mano_original.FirstOrDefault(c => c.Valor == (Valores)15 && c.Pinta == Vira.Pinta);
            if (Perico != null)
            {
                Perico.Valor_envido = Valores_envido.Perico;
                int max_puntaje_envido = jugador.Mano_original.Where(c => c != Perico).Max(c => (int)c.Valor_envido) + 20 + (int)Perico.Valor_envido;     
                return max_puntaje_envido;
            }
            else if(Perica != null)
            {
                Perica.Valor_envido = Valores_envido.Perica;
                int max_puntaje_envido = jugador.Mano_original.Where(c => c != Perica).Max(c => (int)c.Valor_envido) + 20 + (int)Perica.Valor_envido;
                return max_puntaje_envido;
            }
            else
            {
                List<Carta> cartas_pintas_iguales= jugador.Mano_original.GroupBy(c => c.Pinta).OrderByDescending(g => g.Count()).First().ToList();
                if(cartas_pintas_iguales.Count == 2)
                {
                    return cartas_pintas_iguales.Sum(c => (int)c.Valor_envido) + 20;
                }
                else
                {
                    return (int)jugador.Mano_original.Max(c => c.Valor_envido);
                    //return (int)cartas_pintas_iguales.Max(c => c.Valor_envido);
                }
            }
        }
        //Este metodo de obtener_valor_envido no es nada necesario. Podria hacer uso de algo llamado Flags para los enums. Tenerlo en cuenta al crear app mas completa.
        //O tambien podria asignarle valor_envido en cada carta al momento de instanciar el mazo.
        
        
    }
}
