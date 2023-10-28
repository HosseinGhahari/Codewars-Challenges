using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


// Given two integers a and b, which can be positive or negative
// find the sum of all the integers between and including 
// them and return it. If the two numbers are equal return a or b.

// Note: a and b are not ordered!

// Examples (a, b) --> output(explanation)

// (1, 0)-- > 1(1 + 0 = 1)
// (1, 2)-- > 3(1 + 2 = 3)
// (0, 1)-- > 1(0 + 1 = 1)
// (1, 1)-- > 1(1 since both are same)
// (-1, 0)-- > -1(-1 + 0 = -1)
// (-1, 2)-- > 2(-1 + 0 + 1 + 2 = 2)



// My Solution -------->


namespace Beginner_Series__3_Sum_of_Numbers
{

    public class Sum
    {
        public int GetSum(int a, int b)
        {

            int Result = 0;

            if (a == b)
            {
                return a;
            }
            else if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    Result += i;
                }
            }
            else
            {
                for (int i = b; i <= a; i++)
                {
                    Result += i;
                }
            }

            return Result;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Sum sum = new Sum();
            Console.WriteLine(sum.GetSum(0, 1));
            Console.WriteLine(sum.GetSum(0, -1));
            Console.ReadKey();  
        }
    }
}
