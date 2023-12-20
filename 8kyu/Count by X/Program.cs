using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Create a function with two arguments 
// that will return an array of the 
// first n multiples of x.

// Assume both the given number and the 
// number of times to count will be positive 
// numbers greater than 0.

// Return the results as an array or list ( depending on language ).

// Examples
// countBy(1, 10)  should return  {1,2,3,4,5,6,7,8,9,10}
//countBy(2, 5)  should return {2,4,6,8,10}





// My Solution --------------- >



namespace Count_by_X
{

    public static class Kata
    {
        public static int[] CountBy(int x, int n)
        {
            int[] array = new int[n];
            int counter = 1;

            for (int i = 0; i <= n - 1; i++)
            {
                array[i] = x * counter;
                counter++;
            }

            return array;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            foreach(var result in Kata.CountBy(3, 8))
            {
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
