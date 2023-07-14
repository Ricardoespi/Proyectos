using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trucazo_Console
{
    public class Mazo
    {
        private int indice_carta_actual;
        public List<Carta> Cartas { get; set; }
        public Mazo()
        {
            Cartas = new List<Carta>();
            {
                Cartas = new List<Carta>();
                Cartas.Add(new Carta(Carta.Pintas.Espada, Carta.Valores.Espadilla, Carta.Valores_envido.Uno));
                Cartas.Add(new Carta(Carta.Pintas.Espada, Carta.Valores.Dos, Carta.Valores_envido.Dos));
                Cartas.Add(new Carta(Carta.Pintas.Espada, Carta.Valores.Tres, Carta.Valores_envido.Tres));
                Cartas.Add(new Carta(Carta.Pintas.Espada, Carta.Valores.Cuatro, Carta.Valores_envido.Cuatro));
                Cartas.Add(new Carta(Carta.Pintas.Espada, Carta.Valores.Cinco, Carta.Valores_envido.Cinco));
                Cartas.Add(new Carta(Carta.Pintas.Espada, Carta.Valores.Seis, Carta.Valores_envido.Seis));
                Cartas.Add(new Carta(Carta.Pintas.Espada, Carta.Valores.Siete_de_Espada, Carta.Valores_envido.Siete));
                Cartas.Add(new Carta(Carta.Pintas.Espada, Carta.Valores.Diez, Carta.Valores_envido.Diez));
                Cartas.Add(new Carta(Carta.Pintas.Espada, Carta.Valores.Once, Carta.Valores_envido.Once));
                Cartas.Add(new Carta(Carta.Pintas.Espada, Carta.Valores.Doce, Carta.Valores_envido.Doce));
                Cartas.Add(new Carta(Carta.Pintas.Basto, Carta.Valores.Bastillo, Carta.Valores_envido.Uno));
                Cartas.Add(new Carta(Carta.Pintas.Basto, Carta.Valores.Dos, Carta.Valores_envido.Dos));
                Cartas.Add(new Carta(Carta.Pintas.Basto, Carta.Valores.Tres, Carta.Valores_envido.Tres));
                Cartas.Add(new Carta(Carta.Pintas.Basto, Carta.Valores.Cuatro, Carta.Valores_envido.Cuatro));
                Cartas.Add(new Carta(Carta.Pintas.Basto, Carta.Valores.Cinco, Carta.Valores_envido.Cinco));
                Cartas.Add(new Carta(Carta.Pintas.Basto, Carta.Valores.Seis, Carta.Valores_envido.Seis));
                Cartas.Add(new Carta(Carta.Pintas.Basto, Carta.Valores.Siete, Carta.Valores_envido.Siete));
                Cartas.Add(new Carta(Carta.Pintas.Basto, Carta.Valores.Diez, Carta.Valores_envido.Diez));
                Cartas.Add(new Carta(Carta.Pintas.Basto, Carta.Valores.Once, Carta.Valores_envido.Once));
                Cartas.Add(new Carta(Carta.Pintas.Basto, Carta.Valores.Doce, Carta.Valores_envido.Doce));
                Cartas.Add(new Carta(Carta.Pintas.Oro, Carta.Valores.Uno, Carta.Valores_envido.Uno));
                Cartas.Add(new Carta(Carta.Pintas.Oro, Carta.Valores.Dos, Carta.Valores_envido.Dos));
                Cartas.Add(new Carta(Carta.Pintas.Oro, Carta.Valores.Tres, Carta.Valores_envido.Tres));
                Cartas.Add(new Carta(Carta.Pintas.Oro, Carta.Valores.Cuatro, Carta.Valores_envido.Cuatro));
                Cartas.Add(new Carta(Carta.Pintas.Oro, Carta.Valores.Cinco, Carta.Valores_envido.Cinco));
                Cartas.Add(new Carta(Carta.Pintas.Oro, Carta.Valores.Seis, Carta.Valores_envido.Seis));
                Cartas.Add(new Carta(Carta.Pintas.Oro, Carta.Valores.Siete_de_Oro, Carta.Valores_envido.Siete));
                Cartas.Add(new Carta(Carta.Pintas.Oro, Carta.Valores.Diez, Carta.Valores_envido.Diez));
                Cartas.Add(new Carta(Carta.Pintas.Oro, Carta.Valores.Once, Carta.Valores_envido.Once));
                Cartas.Add(new Carta(Carta.Pintas.Oro, Carta.Valores.Doce, Carta.Valores_envido.Doce));
                Cartas.Add(new Carta(Carta.Pintas.Copa, Carta.Valores.Uno, Carta.Valores_envido.Uno));
                Cartas.Add(new Carta(Carta.Pintas.Copa, Carta.Valores.Dos, Carta.Valores_envido.Dos));
                Cartas.Add(new Carta(Carta.Pintas.Copa, Carta.Valores.Tres, Carta.Valores_envido.Tres));
                Cartas.Add(new Carta(Carta.Pintas.Copa, Carta.Valores.Cuatro, Carta.Valores_envido.Cuatro));
                Cartas.Add(new Carta(Carta.Pintas.Copa, Carta.Valores.Cinco, Carta.Valores_envido.Cinco));
                Cartas.Add(new Carta(Carta.Pintas.Copa, Carta.Valores.Seis, Carta.Valores_envido.Seis));
                Cartas.Add(new Carta(Carta.Pintas.Copa, Carta.Valores.Siete, Carta.Valores_envido.Siete));
                Cartas.Add(new Carta(Carta.Pintas.Copa, Carta.Valores.Diez, Carta.Valores_envido.Diez));
                Cartas.Add(new Carta(Carta.Pintas.Copa, Carta.Valores.Once, Carta.Valores_envido.Once));
                Cartas.Add(new Carta(Carta.Pintas.Copa, Carta.Valores.Doce, Carta.Valores_envido.Doce));
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
