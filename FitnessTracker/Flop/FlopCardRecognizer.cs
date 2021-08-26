using FitnessTracker.recognizers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Flop
{
    class FlopCardRecognizer : IFlopRecognizer
    {
        String basePath = "C:\\Users\\asdzxc\\Desktop\\testing recog\\";
        string blackPixelString = "ff000000";

        IPatternHolder patternsHolder = new PokerStartPatternsHolder();

        public string getFlopString(Bitmap flopBitmap)
        {
            string recognizedCardsString = "";

            int startTrimLeftTopX = PatternUtils.findTopLeftX(flopBitmap);
            int startTrimLeftTopY = PatternUtils.findTopLeftY(flopBitmap);

            int endTrimBottomRightX = PatternUtils.findBottomRightX(flopBitmap);
            int endTrimBottomRightY = PatternUtils.findBottomRightY(flopBitmap);

            Rectangle trimRect = new Rectangle(
                startTrimLeftTopX,
                startTrimLeftTopY,
                endTrimBottomRightX - startTrimLeftTopX + 1,
                28//endTrimBottomRightY - startTrimLeftTopY + 1
            );
            Bitmap trimmedHandBitmap = flopBitmap.Clone(trimRect, flopBitmap.PixelFormat);
            //trimmedHandBitmap.Save($"{basePath}trimmed.png", ImageFormat.Png);

            int endXofFirstCard = trimmedHandBitmap.Width / 3;
            for (int x = 0; x < trimmedHandBitmap.Width; x++)
            {
                Boolean thisXAllWhite = true;
                for (int y = 0; y < trimmedHandBitmap.Height; y++)
                {
                    var pixel = trimmedHandBitmap.GetPixel(x, y);
                    if (pixel.Name.ToString() == blackPixelString)
                    {
                        thisXAllWhite = false;
                        break;
                    }
                }

                if (thisXAllWhite && x > 16)
                {
                    endXofFirstCard = x;
                    break;
                }
                else
                {
                    thisXAllWhite = false;
                }
            }

            Rectangle firstCardRect = new Rectangle(0, 0, endXofFirstCard, trimmedHandBitmap.Height);
            Bitmap firstCardBitmap = trimmedHandBitmap.Clone(firstCardRect, trimmedHandBitmap.PixelFormat);
            //firstCardBitmap.Save($"{basePath}first.png", ImageFormat.Png);

            recognizedCardsString += patternsHolder.parsePattern(firstCardBitmap);
            firstCardBitmap.Dispose();


            int startXofSecondCard = trimmedHandBitmap.Width / 3;
            for (int x = endXofFirstCard; x < trimmedHandBitmap.Width; x++)
            {
                Boolean thisXAllWhite = true;
                for (int y = 0; y < trimmedHandBitmap.Height; y++)
                {
                    var pixel = trimmedHandBitmap.GetPixel(x, y);
                    if (pixel.Name.ToString() == blackPixelString)
                    {
                        thisXAllWhite = false;
                        break;
                    }
                }

                if (!thisXAllWhite)
                {
                    startXofSecondCard = x;
                    break;
                }
            }

            int endXofSecondCard = 2 * trimmedHandBitmap.Width / 3;
            for (int x = startXofSecondCard; x < trimmedHandBitmap.Width; x++)
            {
                Boolean thisXAllWhite = true;
                for (int y = 0; y < trimmedHandBitmap.Height; y++)
                {
                    var pixel = trimmedHandBitmap.GetPixel(x, y);
                    if (pixel.Name.ToString() == blackPixelString)
                    {
                        thisXAllWhite = false;
                        break;
                    }
                }

                if (thisXAllWhite && x - startXofSecondCard > 16)
                {
                    endXofSecondCard = x;
                    break;
                }
                else
                {
                    thisXAllWhite = false;
                }
            }

            Rectangle secondCardRect = new Rectangle(startXofSecondCard, 0, endXofSecondCard - startXofSecondCard, trimmedHandBitmap.Height);
            Bitmap secondCardBitmap = trimmedHandBitmap.Clone(secondCardRect, trimmedHandBitmap.PixelFormat);
            //secondCardBitmap.Save($"{basePath}second.png", ImageFormat.Png);
            recognizedCardsString += patternsHolder.parsePattern(secondCardBitmap);
            secondCardBitmap.Dispose();

            int startXofThirdCard = 2 * trimmedHandBitmap.Width / 3;
            for (int x = endXofSecondCard; x < trimmedHandBitmap.Width; x++)
            {
                Boolean thisXAllWhite = true;
                for (int y = 0; y < trimmedHandBitmap.Height; y++)
                {
                    var pixel = trimmedHandBitmap.GetPixel(x, y);
                    if (pixel.Name.ToString() == blackPixelString)
                    {
                        thisXAllWhite = false;
                        break;
                    }
                }

                if (!thisXAllWhite)
                {
                    startXofThirdCard = x;
                    break;
                }
            }

            Rectangle thridCardRect = new Rectangle(startXofThirdCard, 0, trimmedHandBitmap.Width - startXofThirdCard, trimmedHandBitmap.Height);
            Bitmap thirdCardBitmap = trimmedHandBitmap.Clone(thridCardRect, trimmedHandBitmap.PixelFormat);
            //fourthCardBitmap.Save($"{basePath}fourth.png", ImageFormat.Png);
            recognizedCardsString += patternsHolder.parsePattern(thirdCardBitmap);
            thirdCardBitmap.Dispose();

            trimmedHandBitmap.Dispose();

            return recognizedCardsString;
        }

    }
}
