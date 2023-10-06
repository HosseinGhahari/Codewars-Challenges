using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task

//Sum all the numbers of a given array ( cq. list ), except the highest and the lowest element ( by value, not by index! ).

//The highest or lowest element respectively is a single element at each edge, even if there are more than one with the same value.

//Mind the input validation.

//Example
//{ 6, 2, 1, 8, 10 } => 16
//{ 1, 1, 11, 2, 3 } => 6



// My solution



namespace Sum_without_highest_and_lowest_number
{

    public static class Kata
    {
        public static int Sum(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0 || numbers.Length == 1)
            {
                return 0;
            }
            else
            {
                Array.Sort(numbers);

                var result = 0;
                for (int i = 1; i < numbers.Length - 1; i++)
                {
                    result = result + numbers[i];
                }
                return result;
            }
            

        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            var result = Kata.Sum(new[] {});
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
