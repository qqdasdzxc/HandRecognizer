using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Suit
{
    class PSSuitsHolder : ISuitsHolder
    {
        List<CardColor> starsCardColors = new List<CardColor> {
            new CardColor(58, 58, 58, "Black"),
            new CardColor(64, 97, 110, "Blue"),
            new CardColor(92, 143, 55, "Green"),
            new CardColor(133, 43, 38, "Red")
        };
        public List<CardColor> pokerRoomSuits()
        {
            return starsCardColors;
        }
    }
}
