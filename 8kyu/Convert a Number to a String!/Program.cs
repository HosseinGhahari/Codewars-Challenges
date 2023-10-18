using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//We need a function that can transform a number (integer) into a string.

//What ways of achieving this do you know?

//Examples (input --> output):
//123-- > "123"
//999-- > "999"
//- 100-- > "-100"



// My Solution -------->



public class Kata
{
    public static string NumberToString(int num)
    {
        string Result = num.ToString();
        return Result;
    }
}


namespace Convert_a_Number_to_a_String_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.NumberToString(10));
            Console.ReadKey();
        }
    }
}
