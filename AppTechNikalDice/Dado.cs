using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AppTechNikalDice
{
    public class Dado
    {
        public Dado(int NumeroDeCaras)
        {
            Caras = NumeroDeCaras;
        }
        public int Caras { get; set; }

        private Random rng = new Random();
        public int Roll()
        {
            return rng.Next(1, (Caras + 1));
        }
        
        
    }
}
