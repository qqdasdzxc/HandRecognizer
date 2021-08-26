using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.recognizers
{
    class CardPattern
    {
        public string Name;
        public int width;
        public List<int> pixels; //0 - white, 1 - black

        public CardPattern(string Name, int width, List<int> pixels)
        {
            this.Name = Name;
            this.width = width;
            this.pixels = pixels;
        }
    }
}
