using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    class HandStringRepairer
    {
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K", "A" };
        public String repairText(String cardText)
        {
            String repairedString = "";
            Boolean ignoreNextSymbol = false;

            int currentIndex = 0;
            foreach (var c in cardText)
            {
                if (ignoreNextSymbol)
                {
                    ignoreNextSymbol = false;
                    continue;
                }

                if (c == '.')
                {
                    try
                    {
                        char nextsymbol = cardText[currentIndex + 1];
                        if (nextsymbol == '1')
                        {
                            repairedString += 'J';
                            ignoreNextSymbol = true;
                        }
                    }
                    catch { }
                }

                if (c == 'f')
                {
                    try
                    {
                        char nextsymbol = cardText[currentIndex + 1];
                        if (nextsymbol == 'l')
                        {
                            repairedString += 'Q';
                            ignoreNextSymbol = true;
                        }
                    }
                    catch { }
                }

                if (c == 'O' || c == 'G' || c == '0')
                {
                    repairedString += 'Q';
                }

                if (c == '1' || c == '|' || c == 'l' || c == 'I' || c == '|')
                {
                    try
                    {
                        char nextsymbol = cardText[currentIndex + 1];
                        if (nextsymbol == '0' || nextsymbol == 'U' || nextsymbol == 'C' || nextsymbol == 'O')
                        {
                            repairedString += 'T';
                            ignoreNextSymbol = true;
                        }
                    }
                    catch { }
                }
                if (c == 'K')
                {
                    try
                    {
                        char nextsymbol = cardText[currentIndex + 1];
                        if (nextsymbol == ']')
                        {
                            repairedString += 'T';
                            ignoreNextSymbol = true;
                        }
                    }
                    catch { }
                }

                if (c == 'm' || c == 'D')
                {
                    repairedString += 'T';
                }

                if (c == 'B')
                {
                    repairedString += '8';
                }

                if (c == 'S')
                {
                    repairedString += '9';
                }

                if (c == 'E')
                {
                    repairedString += '5';
                }

                if (cards.Contains(c.ToString()))
                {
                    repairedString += c;
                }

                currentIndex++;
            }

            return repairedString;
        }
    }
}
