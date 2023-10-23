using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// Given an array of integers your solution 
// should find the smallest integer.

// For example:

// Given[34, 15, 88, 2] your solution will return 2
// Given [34, -345, -1, 100] your solution will return -345
// You can assume, for the purpose of this kata, that the supplied array will not be empty.



// My Solution -------- >


namespace Find_the_smallest_integer_in_the_array
{

    public class Kata
    {
        public static int FindSmallestInt(int[] args)
        {

            // Solution 1 

            int Holder = args[0];
            for (int i = 0; i < args.Length; i++)
            { 
                if (args[i] < Holder)
                {
                   Holder = args[i];
                }
            }

            return Holder;


            /////////////////////////////////////////////


            // Solution 2 

            // return args.Min();


            /////////////////////////////////////////////


            // Solution 3 

            // int Holder = args.Max();
            // for (int i = 0; i < args.Length; i++)
            // {
            //     if (args[i] < Holder)
            //     {
            //         Holder = args[i];
            //     }
            // }

            // return Holder;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Kata.FindSmallestInt(new int[] { 78, 56, 232, 12, 11, 43 }));
            Console.ReadKey();
        }
    }
}
