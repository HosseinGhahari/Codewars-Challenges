using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Given a set of numbers, return the additive
// inverse of each. Each positive becomes negatives,
// and the negatives become positives.

// [1, 2, 3, 4, 5]-- > [-1, -2, -3, -4, -5]
// [1, -2, 3, -4, 5]-- > [-1, 2, -3, 4, -5]
// []-- > []



// My Solution -------->

namespace Invert_values
{

    public static class ArraysInversion
    {
        public static int[] InvertValues(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = -input[i];
            }

            return input;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            int[] Array = ArraysInversion.InvertValues(new int[] { 1, -2, 3, -4, 5 });
            Console.Write(string.Join(",", Array));
            Console.ReadKey();
        }
    }
}
