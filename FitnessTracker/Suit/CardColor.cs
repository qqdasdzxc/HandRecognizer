using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Suit
{
    class CardColor
    {
        public byte R;
        public byte G;
        public byte B;
        public string Name;

        public CardColor(byte R, byte G, byte B, string Name)
        {
            this.R = R;
            this.G = G;
            this.B = B;
            this.Name = Name;
        }
    }
}
