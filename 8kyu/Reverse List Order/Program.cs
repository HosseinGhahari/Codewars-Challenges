using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// In this kata you will create a function that takes
// in a list and returns a list with the reverse order.

// Examples (Input -> Output)

// * [1, 2, 3, 4]  -> [4, 3, 2, 1]
// * [9, 2, 0, 7]  -> [7, 0, 2, 9]





// My Solution -------------------->


namespace Reverse_List_Order
{
    public class Kata
    {
        public static List<int> ReverseList(List<int> list)
        {
            list.Reverse(); 
            return list;
        }
    }

        
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var numbs in Kata.ReverseList(new List<int>() { 1, 2, 3, 4 }))
            {
                Console.WriteLine(numbs);
            }
            Console.ReadKey();
        }
    }
}
