﻿using System;
using System.Collections.Generic;
using System.Linq;
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
            mazo.Barajar();
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
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine("La mano del segundo jugador es: ");
            foreach (Carta c in mano2) { Console.WriteLine(c.ToString()); }

            Console.ReadKey();

        }
    }
}