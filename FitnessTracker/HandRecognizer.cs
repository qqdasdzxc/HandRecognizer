using FitnessTracker.recognizers;
using System;
using System.Drawing;

namespace FitnessTracker
{
    class HandRecognizer
    {
        String basePath = "C:\\Users\\asdzxc\\Desktop\\testing recog\\";
        HandSuitRecognizer suitRecognizer = new HandSuitRecognizer();
        BitmapInverter bitmapInverter = new BitmapInverter();
        HandStringBuilder builder = new HandStringBuilder();

        IHandRecognizer recognizer = new HandPatternRecognizer();

        public String extractCardText(Bitmap fullHandBitmap)
        {
            String suitsString = suitRecognizer.recognize(fullHandBitmap);

            //Bitmap resizedHandImage = ResizeImage(fullHandBitmap);
            //resizedHandImage.Save($"{basePath}resized.png", ImageFormat.Png);
            Bitmap invertedHand = new Bitmap(fullHandBitmap);
            bitmapInverter.Invert(invertedHand);
            //invertedHand.Save($"{basePath}inverted.png", System.Drawing.Imaging.ImageFormat.Png);

            var cardsText = recognizer.recognizeHand(invertedHand);
            //var repairedCardsText = repairer.repairText(cardsText);

            return builder.combineCardsAndSuits(cardsText, suitsString);
        }

    }
}
