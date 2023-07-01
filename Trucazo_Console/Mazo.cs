using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trucazo_Console
{
    class Mazo
    {
        private int indice_carta_actual;
        public List<Carta> Cartas { get; set; }
        public Mazo()
        {
            Cartas = new List<Carta>();

            foreach (Carta.Pintas suit in Enum.GetValues(typeof(Carta.Pintas)))
            {
                foreach (Carta.Valores valor in Enum.GetValues(typeof(Carta.Valores)))
                {
                    if (valor == Carta.Valores.Siete && suit == Carta.Pintas.Oro)
                        Cartas.Add(new Carta(Carta.Pintas.Oro, Carta.Valores.Tres + 1));
                    else if (valor == Carta.Valores.Siete && suit == Carta.Pintas.Espada)
                        Cartas.Add(new Carta(Carta.Pintas.Espada, Carta.Valores.Tres + 2));
                    else if (valor == Carta.Valores.Uno && suit == Carta.Pintas.Basto)
                        Cartas.Add(new Carta(Carta.Pintas.Basto, Carta.Valores.Tres + 3));
                    else if (valor == Carta.Valores.Uno && suit == Carta.Pintas.Espada)
                        Cartas.Add(new Carta(Carta.Pintas.Espada, Carta.Valores.Tres + 4));
                    else
                        Cartas.Add(new Carta(suit, valor));

                }
            }
        }
        public void Barajar()
        {
            // Shuffle the deck
            Random rng = new Random();
            int n = Cartas.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Carta card = Cartas[k];
                Cartas[k] = Cartas[n];
                Cartas[n] = card;
            }

            // Reset the current card index
            indice_carta_actual = 0;
        }

        public Carta dar_carta()
        {
            // Return the next card from the top of the deck
            if (indice_carta_actual < Cartas.Count)
            {
                Carta siguiente_carta = Cartas[indice_carta_actual];
                indice_carta_actual++;
                return siguiente_carta;
            }
            else
            {
                // No more cards left in the deck
                return null;
            }
        }
    }
}
