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
                    {
                        jugador.Mano.Add(carta);
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
        public void jugar_ronda()
        {
            Jugador ganador_primera_mano;
            //Play a round consisting of 3 hands
            for (int i = 1; i < 4; i++)
            {
                ganador_primera_mano = null;
                Console.WriteLine($"Mano {i}");
                Jugador ganador = jugar_mano();
                if (i == 1 && ganador != null)
                    ganador_primera_mano = ganador;
                // Check if a player has won 2 hands and won the round
                if (ganador != null && manos_ganadas[ganador] >= 2)
                {
                    Console.WriteLine($"{ganador.Nombre} ha ganado la ronda!");
                    actualizar_puntaje(ganador);
                    break;
                }else if(i > 1 && ganador == null && ganador_primera_mano != null)
                {
                    Console.WriteLine($"{ganador_primera_mano.Nombre} ha ganado la ronda!");
                    actualizar_puntaje(ganador_primera_mano);
                    break;
                }
                // Check if there was a tie in the first hand
                if (i == 1 && ganador == null)
                {
                    // Skip the second hand and go directly to the third hand
                    Console.WriteLine("Skipping second hand due to tie in first hand");
                    i++;
                }
                //Check if there was a tie in the third hand.
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
            jugar_envido();
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
        private List<Carta> determinar_ganadoras(List<Carta> cartas_jugadas)
        {
            // Determine the winner of a hand based on the highest card value
            List<Carta> cartas_ganadoras = new List<Carta>();
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
                cartas_ganadoras.Add(Perico);
                Perico.Valor = (Valores)16;
            }
            else if (Perica != null)
            {
                cartas_ganadoras.Add(Perica);
                Perica.Valor = (Valores)15;
            }
            else
            {
                // If no Perico or Perica cards were played, determine winner based on highest value
                var mayor_valor = cartas_jugadas.Max(c => c.Valor);
                foreach (Carta carta in cartas_jugadas)
                {
                    if (carta.Valor == mayor_valor)
                        cartas_ganadoras.Add(carta);
                }
            }
            return cartas_ganadoras;
            //Carta carta_ganadora = cartas_jugadas.OrderByDescending(c => c.Valor).First();
            //return carta_ganadora;
        }
        public void jugar_envido()
        {
            Console.WriteLine("Jugando envido");
            Dictionary<Jugador, int> puntaje_envido = new Dictionary<Jugador, int>();
            foreach (Jugador jugador in Jugadores)
            {
                puntaje_envido[jugador] = calcular_puntaje_envido(jugador);
                Console.WriteLine($"El envido de {jugador.Nombre} es {puntaje_envido[jugador]}");
            }
            Jugador ganador = puntaje_envido.OrderByDescending(j => j.Value).First().Key;
            Console.WriteLine($"{ganador.Nombre} gano el envido");
            actualizar_puntaje(ganador);
        }

        private int calcular_puntaje_envido(Jugador jugador)
        {
            Carta Perico = jugador.Mano_original.FirstOrDefault(c => c.Valor == (Valores)16 && c.Pinta == Vira.Pinta);
            Carta Perica = jugador.Mano_original.FirstOrDefault(c => c.Valor == (Valores)15 && c.Pinta == Vira.Pinta);
            if(Perico != null)
            {
                int max_puntaje_envido = jugador.Mano_original.Where(c => c != Perico).Max(c => (int)obtener_valor_envido(c.Valor)) + 20 + (int)obtener_valor_envido(Perico.Valor);
                return max_puntaje_envido;
            }
            else if(Perica != null)
            {
                return jugador.Mano_original.Where(c => c != Perica).Max(c => (int)obtener_valor_envido(c.Valor)) + 20 + (int)obtener_valor_envido(Perica.Valor);
            }
            else
            {
                List<Carta> cartas_pintas_iguales= jugador.Mano_original.GroupBy(c => c.Pinta).OrderByDescending(g => g.Count()).First().ToList();
                if(cartas_pintas_iguales.Count == 2)
                {
                    return cartas_pintas_iguales.Sum(c => (int)obtener_valor_envido(c.Valor)) + 20;
                }
                else
                {
                    return cartas_pintas_iguales.Max(c => (int)obtener_valor_envido(c.Valor)); 
                }
            }
        }
        //Este metodo de obtener_valor_envido no es nada necesario. Podria hacer uso de algo llamado Flags para los enums. Tenerlo en cuenta al crear app mas completa.
        //O tambien podria asignarle valor_envido en cada carta al momento de instanciar el mazo.
        private Valores_envido obtener_valor_envido(Carta.Valores valor)
        {
            switch (valor)
            {
                case Valores.Diez:
                    return Valores_envido.Diez;
                case Valores.Once:
                    return Valores_envido.Once;
                case Valores.Doce:
                    return Valores_envido.Doce;
                case Valores.Uno:
                    return Valores_envido.Uno;
                case Valores.Dos:
                    return Valores_envido.Dos;
                case Valores.Tres:
                    return Valores_envido.Tres;
                case Valores.Cuatro:
                    return Valores_envido.Cuatro;
                case Valores.Cinco:
                    return Valores_envido.Cinco;
                case Valores.Seis:
                    return Valores_envido.Seis;
                case Valores.Siete:
                    return Valores_envido.Siete;
                case (Valores)11:
                    return Valores_envido.Siete;
                case (Valores)12:
                    return Valores_envido.Siete;
                case (Valores)13:
                    return Valores_envido.Uno;
                case (Valores)14:
                    return Valores_envido.Uno;
                case (Valores)15:
                    return Valores_envido.Siete + 2;
                case (Valores)16:
                    return Valores_envido.Siete + 3;
                default:
                    throw new ArgumentException("Invalid card value for Envido");
            }
        }
    }
}
