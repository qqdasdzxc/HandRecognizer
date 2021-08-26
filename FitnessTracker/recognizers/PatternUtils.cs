using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.recognizers
{
    static class PatternUtils
    {
        static string blackPixelString = "ff000000";
        public static int findTopLeftX(Bitmap handBitmap)
        {
            for (int x = 0; x < handBitmap.Width; x++)
            {
                for (int y = 0; y < handBitmap.Height; y++)
                {
                    var pixel = handBitmap.GetPixel(x, y);
                    if (pixel.Name.ToString() == blackPixelString)
                    {
                        return x;
                    }
                }
            }

            throw new Exception();
        }

        public static int findTopLeftY(Bitmap handBitmap)
        {
            for (int y = 0; y < handBitmap.Height; y++)
            {
                for (int x = 0; x < handBitmap.Width; x++)
                {
                    var pixel = handBitmap.GetPixel(x, y);
                    if (pixel.Name.ToString() == blackPixelString)
                    {
                        return y;
                    }
                }
            }

            throw new Exception();
        }
        public static int findBottomRightX(Bitmap handBitmap)
        {
            for (int x = handBitmap.Width - 1; x > 0; x--)
            {
                for (int y = handBitmap.Height - 1; y > 0; y--)
                {
                    var pixel = handBitmap.GetPixel(x, y);
                    if (pixel.Name.ToString() == blackPixelString)
                    {
                        return x;
                    }
                }
            }

            throw new Exception();
        }

        public static int findBottomRightY(Bitmap handBitmap)
        {
            for (int y = handBitmap.Height - 1; y > 0; y--)
            {
                for (int x = handBitmap.Width - 1; x > 0; x--)
                {
                    var pixel = handBitmap.GetPixel(x, y);
                    if (pixel.Name.ToString() == blackPixelString)
                    {
                        return y;
                    }
                }
            }

            throw new Exception();
        }
    }
}
