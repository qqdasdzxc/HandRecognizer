using System.Drawing;
using Tesseract;

namespace FitnessTracker.recognizers
{
    class TesseractRecognizer : IHandRecognizer
    {
        TesseractEngine ocrEngine;

        public string recognizeHand(Bitmap handBitmap)
        {
            var path = "C:\\Users\\asdzxc\\Source\\repos\\FitnessTracker\\FitnessTracker\\bin\\Debug\\tessdata";//path.Replace("file:\\", "");
            var ENGLISH_LANGUAGE = "eng";
            ocrEngine = new TesseractEngine(path, ENGLISH_LANGUAGE, EngineMode.Default);
            var page = ocrEngine.Process(handBitmap);

            return page.GetText();
        }
    }
}
