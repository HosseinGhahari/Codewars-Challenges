using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Your function takes two arguments:

// current father's age (years)
// current age of his son (years)

// Сalculate how many years ago the father 
// was twice as old as his son (or in 
// how many years he will be twice as old).
// The answer is always greater or equal to 0,
// no matter if it was in the past or it is in the future.




// My Solution ----------- >



namespace Twice_as_old
{

    public class TwiceAsOldSolution
    {
        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            
            int result = dadYears - (sonYears + sonYears);
           
            if (sonYears * 2 > dadYears)
            {
                result = (sonYears * 2) - dadYears;
                return result;
            }
    
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TwiceAsOldSolution.TwiceAsOld(30,7));
            Console.ReadKey();
        }
    }
}
