using Sum_of_a_sequence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Your task is to write a function
//which returns the sum of a sequence of integers.

//The sequence is defined by 3 non-negative 
//values: begin, end, step.

//If begin value is greater than the end,
//your function should return 0. If end is
//not the result of an integer number of steps,
//then don't add it to the sum. See the 4th example below.

//Examples

//2,2,2 --> 2
//2,6,2 --> 12 (2 + 4 + 6)
//1,5,1-- > 15(1 + 2 + 3 + 4 + 5)
//1,5,3-- > 5(1 + 4)





// My Solution --------------------- >

namespace Sum_of_a_sequence
{

    public static class Kata
    {
        public static int SequenceSum(int start, int end, int step)
          {

            int Result = 0;
            int test = 0;
            if (start > end)
            {
                return 0;
            }

            for (int i = start; i <= end ; i+=step)
            {
                start = start + step;
                test = start - step ;
                Result += test;
            }

            return Result;

        }
    }
}


    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.SequenceSum(1, 15, 3));
            Console.ReadKey();
        }
    }

