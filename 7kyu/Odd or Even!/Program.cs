using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Task: 

// Given a list of integers, determine whether 
// the sum of its elements is odd or even.

// Give your answer as a string matching "odd" or "even".

// If the input array is empty consider it as: [0] (array with a zero).

// Examples:

// Input: [0]
// Output: "even"

// Input: [0, 1, 4]
// Output: "odd"

// Input: [0, -1, -5]
// Output: "even"
 



// My Solution ---------------------->



namespace Odd_or_Even_
{

    public class Kata
    {
        public static string OddOrEven(int[] array)
        {
            if (array.Sum() % 2 == 0)
            {
                return "even";
            }
            return "odd";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.OddOrEven(new int[] { 0, 1, 5 }));
            Console.WriteLine(Kata.OddOrEven(new int[] { 0, 1, -4 }));
            Console.ReadKey();
        }

    }
}
