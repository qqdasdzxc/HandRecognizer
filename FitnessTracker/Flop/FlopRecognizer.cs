using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Flop
{
    class FlopRecognizer
    {
        String basePath = "C:\\Users\\asdzxc\\Desktop\\testing recog\\";
        FlopSuitRecognizer suitRecognizer = new FlopSuitRecognizer();
        BitmapInverter bitmapInverter = new BitmapInverter();
        FlopStringBuilder builder = new FlopStringBuilder();

        IFlopRecognizer recognizer = new FlopCardRecognizer();

        public string getFlopString(Bitmap flopBitmap)
        {
            String suitsString = suitRecognizer.recognize(flopBitmap);
            Bitmap invertedFlop = new Bitmap(flopBitmap);
            bitmapInverter.Invert(invertedFlop);
            var cardsText = recognizer.getFlopString(invertedFlop);

            String flopString = builder.combineCardsAndSuits(cardsText, suitsString);
            return sortFlopCards(flopString);
        }

        private String sortFlopCards(String flopString)
        {
            String firstCard = flopString.Substring(0, 2);
            String secondCard = flopString.Substring(2, 2);
            String thirdCard = flopString.Substring(4, 2);

            int firstCardInt = convertInfoInt(firstCard[0]);
            int secondCardInt = convertInfoInt(secondCard[0]);
            int thirdCardInt = convertInfoInt(thirdCard[0]);

            int max = Math.Max(firstCardInt, Math.Max(secondCardInt, thirdCardInt));
            int min = -Math.Max(-firstCardInt, Math.Max(-secondCardInt, -thirdCardInt));
            int mid = (firstCardInt + secondCardInt + thirdCardInt) -
                      (max + min);

            if (max == firstCardInt && mid == secondCardInt && min == thirdCardInt)
            {
                return $"{firstCard}{secondCard}{thirdCard}";
            }
            if (max == firstCardInt && mid == thirdCardInt && min == secondCardInt)
            {
                return $"{firstCard}{thirdCard}{secondCard}";
            }

            if (max == secondCardInt && mid == firstCardInt && min == thirdCardInt)
            {
                return $"{secondCard}{firstCard}{thirdCard}";
            }
            if (max == secondCardInt && mid == thirdCardInt && min == firstCardInt)
            {
                return $"{secondCard}{thirdCard}{firstCard}";
            }

            if (max == thirdCardInt && mid == firstCardInt && min == secondCardInt)
            {
                return $"{thirdCard}{firstCard}{secondCard}";
            }
            if (max == thirdCardInt && mid == secondCardInt && min == firstCardInt)
            {
                return $"{thirdCard}{secondCard}{firstCard}";
            }

            throw new Exception();
        }

        private int convertInfoInt(Char cardchar)
        {
            switch (cardchar)
            {
                case 'A': return 14;
                case 'K': return 13;
                case 'Q': return 12;
                case 'J': return 11;
                case 'T': return 10;

                default: return Int32.Parse(cardchar.ToString());
            }
        }
    }
}
