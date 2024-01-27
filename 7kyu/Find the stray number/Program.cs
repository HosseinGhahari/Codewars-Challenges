using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//You are given an odd-length array of integers, 
//in which all of them are the same, except for 
//one single number.

//Complete the method which accepts such an array, 
//and returns that single different number.

//The input array will always be valid! (odd-length >= 3)

//Examples

//[1, 1, 2] ==> 2
//[17, 17, 3, 17, 17, 17, 17] ==> 3





// My Solution ----------------->


namespace Find_the_stray_number
{

    class Solution
    {
        public static int Stray(int[] numbers)
        {

            int Result = 0;
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    Result = numbers[i];
                    break;
                }
                else if (numbers[i] == numbers[i + 1])
                {
                    Result = numbers[numbers.Length - 1];
                    break;
                }
            }

            return Result;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(Solution.Stray(new int[] { 17 , 17 , 3 , 17 }));
            foreach (var Result in numbers)
            {
                Console.WriteLine(Result);
            }
            Console.ReadKey();
        }
    }
}
