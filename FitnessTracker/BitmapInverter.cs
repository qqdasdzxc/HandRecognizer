using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    class BitmapInverter
    {
        public void Invert(Bitmap Bmp)
        {
            Color c;

            for (int y = 0; y < Bmp.Height; y++)
                for (int x = 0; x < Bmp.Width; x++)
                {
                    c = Bmp.GetPixel(x, y);
                    if (c.Name.ToLower() == "ffffffff")
                    {
                        /*Bmp.SetPixel(x - 10, y, Color.FromArgb(0, 0, 0));
                        Bmp.SetPixel(x - 9, y, Color.FromArgb(0, 0, 0));
                        Bmp.SetPixel(x - 8, y, Color.FromArgb(0, 0, 0));
                        Bmp.SetPixel(x - 7, y, Color.FromArgb(0, 0, 0));
                        Bmp.SetPixel(x - 6, y, Color.FromArgb(0, 0, 0));*/
                         /*try
                         {
                             Bmp.SetPixel(x - 5, y, Color.FromArgb(0, 0, 0));
                         }
                         catch { }

                        try
                        {
                            Bmp.SetPixel(x - 4, y, Color.FromArgb(0, 0, 0));
                        }
                        catch { }*/

                        /*try
                        {
                            Bmp.SetPixel(x - 3, y, Color.FromArgb(0, 0, 0));
                        }
                        catch { }

                        try
                        {
                            Bmp.SetPixel(x - 2, y, Color.FromArgb(0, 0, 0));
                        }
                        catch { }

                        try
                        {
                            Bmp.SetPixel(x - 1, y, Color.FromArgb(0, 0, 0));
                        }
                        catch { }*/

                        /*try
                        {
                            Bmp.SetPixel(x, y - 5, Color.FromArgb(0, 0, 0));
                        }
                        catch { }

                         try
                         {
                             Bmp.SetPixel(x, y - 4, Color.FromArgb(0, 0, 0));
                         }
                         catch { }*/
                        
                        /*try
                        {
                            Bmp.SetPixel(x, y - 3, Color.FromArgb(0, 0, 0));
                        }
                        catch { }

                        try
                        {
                            Bmp.SetPixel(x, y - 2, Color.FromArgb(0, 0, 0));
                        }
                        catch { }

                        try
                        {
                            Bmp.SetPixel(x, y - 1, Color.FromArgb(0, 0, 0));
                        }
                        catch { }*/


                        /*Bmp.SetPixel(x, y - 10, Color.FromArgb(0, 0, 0));
                        Bmp.SetPixel(x, y - 9, Color.FromArgb(0, 0, 0));
                        Bmp.SetPixel(x, y - 8, Color.FromArgb(0, 0, 0));
                        Bmp.SetPixel(x, y - 7, Color.FromArgb(0, 0, 0));
                        Bmp.SetPixel(x, y - 6, Color.FromArgb(0, 0, 0));*/
                        /*Bmp.SetPixel(x, y - 5, Color.FromArgb(0, 0, 0));
                        Bmp.SetPixel(x, y - 4, Color.FromArgb(0, 0, 0));
                        Bmp.SetPixel(x, y - 3, Color.FromArgb(0, 0, 0));
                        Bmp.SetPixel(x, y - 2, Color.FromArgb(0, 0, 0));
                        Bmp.SetPixel(x, y - 1, Color.FromArgb(0, 0, 0));*/
                        Bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                    else
                    {
                        Bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                }

            /*Bmp.SetPixel(0, 0, Color.FromArgb(0, 0, 0));
            Bmp.SetPixel(0, 1, Color.FromArgb(0, 0, 0));
            Bmp.SetPixel(0, 2, Color.FromArgb(0, 0, 0));*/
            /*Bmp.SetPixel(0, Bmp.Height, Color.FromArgb(0, 0, 0));
            Bmp.SetPixel(Bmp.Width, 0, Color.FromArgb(0, 0, 0));
            Bmp.SetPixel(Bmp.Width, Bmp.Height, Color.FromArgb(0, 0, 0));*/
        }
    }
}
