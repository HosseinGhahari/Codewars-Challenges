using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Find the number with the most digits.

// If two numbers in the argument array
// have the same number of digits, return the first one in the array.


namespace Most_digits
{

    public class Kata
    {
        public static int FindLongest(int[] number)
        {
            var result = 0;
            var num = number.Max().ToString().Length;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i].ToString().Length == num)
                {
                    result = number[i];
                    break;
                }
            }

            return result;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.FindLongest(new int[] { 8, 900, 500 }));
            Console.ReadKey();
        }
    }
}
