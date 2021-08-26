using Patagames.Ocr;
using Patagames.Ocr.Enums;
using System.Drawing;

namespace FitnessTracker.recognizers
{
    class OcrApiRecognizer : IHandRecognizer
    {
        public string recognizeHand(Bitmap handBitmap)
        {
            using (var api = OcrApi.Create())
            {
                api.Init(Languages.English);
                string recognizedText = api.GetTextFromImage(handBitmap);
                handBitmap.Dispose();

                return recognizedText;
            }
        }
    }
}
