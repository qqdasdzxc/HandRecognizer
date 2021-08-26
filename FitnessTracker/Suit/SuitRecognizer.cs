using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Suit
{
    class SuitRecognizer
    {
        ISuitsHolder suitsHolder = new PSSuitsHolder();
        
        public String getSingleCardSuitChar(Bitmap cardBitmap)
        {
            Color cardColor = getCardColor(cardBitmap);
            CardColor knownCardColor = closestColor2(cardColor);

            return getSuitString(knownCardColor);
        }

        CardColor closestColor2(Color target)
        {
            List<CardColor> currentRoomCardColors = suitsHolder.pokerRoomSuits();
            var colorDiffs = currentRoomCardColors.Select(n => ColorDiff(n, target)).Min(n => n);
            var minDiffIndex = currentRoomCardColors.FindIndex(n => ColorDiff(n, target) == colorDiffs);
            return currentRoomCardColors[minDiffIndex];
        }

        // distance in RGB space
        int ColorDiff(CardColor c1, Color c2)
        {
            return (int)Math.Sqrt((c1.R - c2.R) * (c1.R - c2.R)
                                   + (c1.G - c2.G) * (c1.G - c2.G)
                                   + (c1.B - c2.B) * (c1.B - c2.B));
        }

        private Color getCardColor(Bitmap cardBitmap)
        {
            int centerX = 6;
            int centerY = cardBitmap.Height / 2;

            return cardBitmap.GetPixel(centerX, centerY);
        }

        private String getSuitString(CardColor cardColor)
        {
            switch (cardColor.Name)
            {
                case "Black":
                    return "s";

                case "Green":
                    return "c";

                case "Red":
                    return "h";

                case "Blue":
                    return "d";

                default: return "x";
            }
        }
    }
}
