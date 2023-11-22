using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

// Given a string, you have to return a 
// string in which each character 
// (case-sensitive) is repeated once.

// Examples(Input->Output):
// *"String"-> "SSttrriinngg"
// * "Hello World"-> "HHeelllloo  WWoorrlldd"
// * "1234!_ "-> "11223344!!__  "



// My Solution ----------->


namespace Double_Char
{

    public class Kata
    {
        public static string DoubleChar(string s)
        {
            string Result = "";

            for (int i = 0; i < s.Length; i++)
            {
                Result += string.Concat(Enumerable.Repeat(s[i], 2));
            }

            return Result;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.DoubleChar("Adidas"));
            Console.ReadKey();
        }
    }
}
