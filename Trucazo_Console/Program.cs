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

            Juego juego = new Juego();
            juego.add_player(new Jugador("Ricardo"));
            juego.add_player(new Jugador("Carlitos"));
            juego.Mazo.Barajar();
            juego.reparte_cartas();
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine($"Jugando mano {i}");
                juego.jugar_mano();
            }
            Console.ReadKey();


        }
    }
}
