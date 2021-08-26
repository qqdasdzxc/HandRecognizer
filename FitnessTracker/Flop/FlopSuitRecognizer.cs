using FitnessTracker.Suit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Flop
{
    class FlopSuitRecognizer
    {
        String basePath = "C:\\Users\\asdzxc\\Desktop\\testing recog\\";
        SuitRecognizer suitRecognizer = new SuitRecognizer();

        public String recognize(Bitmap flopBitmap)
        {
            Rectangle firstCardColorRect = new Rectangle(0, flopBitmap.Height / 2, flopBitmap.Width / 3, flopBitmap.Height / 2);
            Bitmap firstCardColorBitmap = flopBitmap.Clone(firstCardColorRect, flopBitmap.PixelFormat);
            //firstCardColorBitmap.Save($"{basePath}firstCardColorBitmap.png", ImageFormat.Png);
            string firstCardSuitString = suitRecognizer.getSingleCardSuitChar(firstCardColorBitmap);
            firstCardColorBitmap.Dispose();

            Rectangle secondCardColorRect = new Rectangle(flopBitmap.Width / 3, flopBitmap.Height / 2, flopBitmap.Width / 3, flopBitmap.Height / 2);
            Bitmap secondCardColorBitmap = flopBitmap.Clone(secondCardColorRect, flopBitmap.PixelFormat);
            //secondCardColorBitmap.Save($"{basePath}secondCardColorBitmap.png", ImageFormat.Png);
            string secondCardSuitString = suitRecognizer.getSingleCardSuitChar(secondCardColorBitmap);
            secondCardColorBitmap.Dispose();

            Rectangle thirdCardColorRect = new Rectangle(2 * flopBitmap.Width / 3, flopBitmap.Height / 2, flopBitmap.Width / 3, flopBitmap.Height / 2);
            Bitmap thirdCardColorBitmap = flopBitmap.Clone(thirdCardColorRect, flopBitmap.PixelFormat);
            //thirdCardColorBitmap.Save($"{basePath}thirdCardColorBitmap.png", ImageFormat.Png);
            string thirdCardSuitString = suitRecognizer.getSingleCardSuitChar(thirdCardColorBitmap);
            thirdCardColorBitmap.Dispose();

            return $"{firstCardSuitString}{secondCardSuitString}{thirdCardSuitString}";
        }

    }
}
