using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Given an array of integers as strings and numbers,
// return the sum of the array values as if all were numbers.
// Return your answer as a number.




// My Solution ------------------>


namespace Sum_Mixed_Array
{
    public class Kata
    {
        public static int SumMix(object[] x)
        {
            int total = 0;
            for (int i = 0; i < x.Length; i++)
            {
                total += Convert.ToInt32(x[i]);
            }
            return total;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.SumMix(new object[] { 9, 3, "7", "3" }));
            Console.ReadKey();
        }
    }
}
