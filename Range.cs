using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_RPG
{
    class Range
    {

        int low;
        int high;


        public static int random(Range range)
        {

            Random random = new Random();



            return random.Next(range.low, range.high);
        }
       
        public static int random(int low, int high)
        {

            Random random = new Random();
            return random.Next(low, high);
        }



    }
}
