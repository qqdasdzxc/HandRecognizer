using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.recognizers
{
    class HandPatternRecognizer : IHandRecognizer
    {
        String basePath = "C:\\Users\\asdzxc\\Desktop\\testing recog\\";
        static string blackPixelString = "ff000000";

        IPatternHolder patternsHolder = new PokerStartPatternsHolder();

        public string recognizeHand(Bitmap handBitmap)
        {
            string recognizedCardsString = "";

            int startTrimLeftTopX = PatternUtils.findTopLeftX(handBitmap);
            int startTrimLeftTopY = PatternUtils.findTopLeftY(handBitmap);

            int endTrimBottomRightX = PatternUtils.findBottomRightX(handBitmap);
            int endTrimBottomRightY = PatternUtils.findBottomRightY(handBitmap);

            Rectangle trimRect = new Rectangle(
                startTrimLeftTopX,
                startTrimLeftTopY,
                endTrimBottomRightX - startTrimLeftTopX + 1,
                28//endTrimBottomRightY - startTrimLeftTopY + 1
            );
            Bitmap trimmedHandBitmap = handBitmap.Clone(trimRect, handBitmap.PixelFormat);
            //trimmedHandBitmap.Save($"{basePath}trimmed.png", ImageFormat.Png);

            int endXofFirstCard = trimmedHandBitmap.Width / 4;
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


            int startXofSecondCard = trimmedHandBitmap.Width / 4;
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

            int endXofSecondCard = 2 * trimmedHandBitmap.Width / 4;
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

            int startXofThirdCard = 2 * trimmedHandBitmap.Width / 4;
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

            int endXofThirdCard = 3 * trimmedHandBitmap.Width / 4;
            for (int x = startXofThirdCard; x < trimmedHandBitmap.Width; x++)
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

                if (thisXAllWhite && x - startXofThirdCard > 16)
                {
                    endXofThirdCard = x;
                    break;
                }
                else
                {
                    thisXAllWhite = false;
                }
            }

            Rectangle thirdCardRect = new Rectangle(startXofThirdCard, 0, endXofThirdCard - startXofThirdCard, trimmedHandBitmap.Height);
            Bitmap thirdCardBitmap = trimmedHandBitmap.Clone(thirdCardRect, trimmedHandBitmap.PixelFormat);
            //thirdCardBitmap.Save($"{basePath}third.png", ImageFormat.Png);
            recognizedCardsString += patternsHolder.parsePattern(thirdCardBitmap);
            thirdCardBitmap.Dispose();


            int startXofFourthCard = 3 * trimmedHandBitmap.Width / 4;
            for (int x = endXofThirdCard; x < trimmedHandBitmap.Width; x++)
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
                    startXofFourthCard = x;
                    break;
                }
            }

            Rectangle fourthCardRect = new Rectangle(startXofFourthCard, 0, trimmedHandBitmap.Width - startXofFourthCard, trimmedHandBitmap.Height);
            Bitmap fourthCardBitmap = trimmedHandBitmap.Clone(fourthCardRect, trimmedHandBitmap.PixelFormat);
            //fourthCardBitmap.Save($"{basePath}fourth.png", ImageFormat.Png);
            recognizedCardsString += patternsHolder.parsePattern(fourthCardBitmap);
            fourthCardBitmap.Dispose();

            trimmedHandBitmap.Dispose();

            return recognizedCardsString;
        }

        

    }
}
