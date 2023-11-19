using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Timmy & Sarah think they are in love, but around
// where they live, they will only know once they pick 
// a flower each. If one of the flowers has an even number 
// of petals and the other has an odd number of petals it means 
// they are in love.

// Write a function that will take the number of petals 
// of each flower and return true if they are in love and false if they aren't.




// My Solution ---------->


namespace Opposites_Attract
{
    public class LoveDetector
    {
        public static bool lovefunc(int flower1, int flower2)
        {

            if (flower1 % 2 == 0 && flower2 % 2 != 0 || flower1 % 2 != 0 && flower2 % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(LoveDetector.lovefunc(0,3));
            Console.ReadKey();
        }
    }
}
