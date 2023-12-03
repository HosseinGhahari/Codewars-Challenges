using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Complete the function that takes two integers 
// (a, b, where a < b) and return an array of all 
// integers between the input parameters, including them.

// For example:

// a = 1
// b = 4

// -- > [1, 2, 3, 4]





// My Solution ----------->


namespace What_is_between_
{
    public class Kata
    {
        public static int[] Between(int a, int b)
        {

            List<int> list = new List<int>();

            for (int i = a; i <= b; i++)
            {
                list.Add(i);
            }

            return list.ToArray();


            // OR


            return Enumerable.Range(a, b).ToArray();

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            foreach(var result in Kata.Between(1, 5))
            {
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
