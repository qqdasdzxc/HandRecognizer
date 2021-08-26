using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    class HandStringBuilder
    {
        public String combineCardsAndSuits(String cardsText, String suits)
        {
            String result = "";

            for (int i = 0; i < 4; i++)
            {
                try
                {
                    result += cardsText[i];
                    result += suits[i];
                }
                catch
                {
                    result += " ";
                    result += suits[i];
                }
            }

            return result;
        }
    }
}
