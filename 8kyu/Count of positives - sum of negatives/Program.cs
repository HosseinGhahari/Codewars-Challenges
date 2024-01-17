using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Given an array of integers.

//Return an array, where the first element
//is the count of positives numbers and the 
//second element is sum of negative numbers.
//0 is neither positive nor negative.

//If the input is an empty array or is null, return an empty array.

//Example
//For input [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15], 
//you should return [10, -65].




// My Solution -------------- >


namespace Count_of_positives___sum_of_negatives
{

    public class Kata
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            
            if (input == null )
            {
                return new int[0];
            }
            if (input.Length == 0)
            {
                return input;
            }
        
            var counter1 = input.Count(x => x > 0);
            var counter2 = input.Where(a => a < 0).Sum();
            var arr = new int[2] { counter1, counter2 };
            return arr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            foreach(var Result in Kata.CountPositivesSumNegatives(new int[] {}))
            {
                Console.WriteLine(Result);
            }
            Console.ReadKey();
        }
    }
}
