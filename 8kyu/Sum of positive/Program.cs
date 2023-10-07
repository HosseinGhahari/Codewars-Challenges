using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//You get an array of numbers, return the sum of all of the positives ones.

//Example [1,-4,7,12] => 1 + 7 + 12 = 20

//Note: if there is nothing to sum, the sum is default to 0.



// My Solution --->


namespace Sum_of_positive
{

    public class Kata
    {

        public static int PositiveSum(int[] arr)
        {
            int Sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    Sum += arr[i];
                }
            }

            return Sum;
        }

    }

    
    class Program
    {
        static void Main(string[] args)
        {
            var Sums = new int[] {2,3,7,-5,1,-8,4 };
            var Result = Kata.PositiveSum(Sums);
            Console.WriteLine($"Sum of positive numbers are : {Result}");
            Console.ReadKey();
        }
    }
}
