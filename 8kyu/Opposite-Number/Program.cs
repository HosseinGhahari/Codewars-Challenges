using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// Very simple, given an integer or a floating-point number, find its opposite.

// Examples:

// 1: -1
// 14: -14
// -34: 34


// My Solution : 


public class Kata
{
    public static int Opposite(int number)
    {
        return number - (number * 2);
    }
}



namespace Opposite_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Kata.Opposite(25));
            Console.ReadKey();
        }
    }
}
