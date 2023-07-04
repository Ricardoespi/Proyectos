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
            /*
             * foreach (Carta carta in mazo.Cartas)
            {
                Console.WriteLine(carta.ToString());
            }
            */
            /*mazo.Barajar();
            Carta Vira = mazo.dar_carta();
            Console.WriteLine(Vira.ToString());
            List<Carta> mano1 = new List<Carta>();
            List<Carta> mano2 = new List<Carta>();
            mano1.Add(mazo.dar_carta());
            mano1.Add(mazo.dar_carta());
            mano1.Add(mazo.dar_carta());
            mano2.Add(mazo.dar_carta());
            mano2.Add(mazo.dar_carta());
            mano2.Add(mazo.dar_carta());
            Console.WriteLine("La mano del primer jugador es: ");
            foreach (Carta c in mano1) {
                Console.WriteLine(c.ToString() + "(" + c.Valor + ")");
            }
            Console.WriteLine("La mano del segundo jugador es: ");
            foreach (Carta c in mano2) { Console.WriteLine(c.ToString() + "(" + c.Valor + ")"); }
            if (mano1[0].Valor > mano2[0].Valor)
                Console.WriteLine("El primer jugador gana");
            else if (mano1[0].Valor < mano2[0].Valor)
                Console.WriteLine("El segundo jugador gana");
            else
                Console.WriteLine("Empate");
            if ((int)Carta.Valores.Tres > (int)mazo.Cartas[4].Valor)
                Console.WriteLine("El siete de espadas es mayor que un 3");*/
            //crea un nuevo juego
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
                juego.jugar_ronda();
                if (juego.check_ganador())
                    break;
                Jugador siguiente_barajador = juego.Jugadores.First(p => p != juego.ultimo_barajador);
                juego.reset_mazo(siguiente_barajador);
                //juego.baraja_mazo(siguiente_barajador);
                //for (int i = 1; i < 4; i++)
                //{
                //    Console.WriteLine($"Jugando mano {i}");
                //    juego.jugar_mano();
                //}
                //if (juego.check_ganador())
                //    break;

            }
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();

        }
    }
}
