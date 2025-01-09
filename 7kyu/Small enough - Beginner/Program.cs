using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 
You will be given an array and a limit value.
You must check that all values in the array are
below or equal to the limit value. If they are,
return true. Else, return false.

You can assume all values in the array are numbers.
 
 
*/


// My Solution -------------->


namespace Small_enough___Beginner
{
    public class Kata
    {
        public static bool SmallEnough(int[] a, int limit)
        {

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > limit)
                {
                    return false;
                }
            }

            return true;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.SmallEnough
                (new int[] { 78, 117, 110, 99, 104, 117, 107, 115 }, 100));
            Console.ReadKey();
        }
    }
}
