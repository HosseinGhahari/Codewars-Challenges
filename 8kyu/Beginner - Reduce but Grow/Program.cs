using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// Given a non-empty array of integers, return 
// the result of multiplying the values together 
// in order. Example:

// [1, 2, 3, 4] => 1 * 2 * 3 * 4 = 24



// My Solution --------- >



namespace Beginner___Reduce_but_Grow
{

    public class Kata
    {
        public static int Grow(int[] x)
        {


            // Solution 1

            int Result = x[0];

            for (int i = 1; i < x.Length; i++)
            {
                Result = Result * x[i];    
            }

            return Result;



            // Solution 2

            // return x.Aggregate((a, b) => a * b);
            
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Grow(new[] { 2, 2, 2, 2, 2, 2 }));
            Console.ReadKey();
        }

    }
}
