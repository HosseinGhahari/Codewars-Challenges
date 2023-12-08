using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Write a function that takes an array of strings 
// as an argument and returns a sorted array containing 
// the same strings, ordered from shortest to longest.

// For example, if this array were passed as an argument:

// ["Telescopes", "Glasses", "Eyes", "Monocles"]

// Your function would return the following array:

// ["Eyes", "Glasses", "Monocles", "Telescopes"]

// All of the strings in the array passed to your function 
// will be different lengths, so you will not have to decide 
// how to order multiple strings of the same length.





// My Solution --------------->



namespace Sort_array_by_string_length
{
    public class Kata
    {
        public static string[] SortByLength(string[] array)
        {
            return array.OrderBy(x =>x.Length).ToArray();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Kata.SortByLength(new string[] { "Beg", "Life", "I", "To" }))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
