using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implement the function unique_in_order 
//which takes as argument a sequence and 
//returns a list of items without any 
//elements with the same value next to 
//each other and preserving the original 
//order of elements.

//For example:

//uniqueInOrder("AAAABBBCCDAABBB") == { 'A', 'B', 'C', 'D', 'A', 'B'}
//uniqueInOrder("ABBCcAD") == { 'A', 'B', 'C', 'c', 'A', 'D'}
//uniqueInOrder([1, 2, 2, 3, 3]) == { 1,2,3}




// My Solution -------------->

namespace Unique_In_Order
{

    public static class Kata
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            var first = iterable.First();

            var Result = new List<T>();

            Result.Add(first);

            foreach (var item in iterable)
            {
                if (item.Equals(first))
                {
                    continue;
                }
                first = item;
                Result.Add(item);
            }

            return Result;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            foreach (var result in Kata.UniqueInOrder("AAAABBBCCDAABBB"))
            {
                Console.Write(result);
            }

            Console.ReadKey();
        }
    }
}
