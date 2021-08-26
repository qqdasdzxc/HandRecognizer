using FitnessTracker.Suit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace FitnessTracker
{
    class HandSuitRecognizer
    {
        SuitRecognizer suitRecognizer = new SuitRecognizer();
        public String recognize(Bitmap fullHandBitmap)
        {
            Rectangle firstCardColorRect = new Rectangle(0, fullHandBitmap.Height / 2, fullHandBitmap.Width / 4, fullHandBitmap.Height / 2);
            Bitmap firstCardColorBitmap = fullHandBitmap.Clone(firstCardColorRect, fullHandBitmap.PixelFormat);
            string firstCardSuitString = suitRecognizer.getSingleCardSuitChar(firstCardColorBitmap);
            firstCardColorBitmap.Dispose();

            Rectangle secondCardColorRect = new Rectangle(fullHandBitmap.Width / 4, fullHandBitmap.Height / 2, fullHandBitmap.Width / 4, fullHandBitmap.Height / 2);
            Bitmap secondCardColorBitmap = fullHandBitmap.Clone(secondCardColorRect, fullHandBitmap.PixelFormat);
            string secondCardSuitString = suitRecognizer.getSingleCardSuitChar(secondCardColorBitmap);
            secondCardColorBitmap.Dispose();

            Rectangle thirdCardColorRect = new Rectangle(2 * fullHandBitmap.Width / 4, fullHandBitmap.Height / 2, fullHandBitmap.Width / 4, fullHandBitmap.Height / 2);
            Bitmap thirdCardColorBitmap = fullHandBitmap.Clone(thirdCardColorRect, fullHandBitmap.PixelFormat);
            string thirdCardSuitString = suitRecognizer.getSingleCardSuitChar(thirdCardColorBitmap);
            thirdCardColorBitmap.Dispose();

            Rectangle fourthCardColorRect = new Rectangle(3 * fullHandBitmap.Width / 4, fullHandBitmap.Height / 2, fullHandBitmap.Width / 4, fullHandBitmap.Height / 2);
            Bitmap fourthCardColorBitmap = fullHandBitmap.Clone(fourthCardColorRect, fullHandBitmap.PixelFormat);
            string fourthCardSuitString = suitRecognizer.getSingleCardSuitChar(fourthCardColorBitmap);
            fourthCardColorBitmap.Dispose();

            return $"{firstCardSuitString}{secondCardSuitString}{thirdCardSuitString}{fourthCardSuitString}";
        }

        
    }
}
