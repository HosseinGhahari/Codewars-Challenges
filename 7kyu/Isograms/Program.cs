using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// An isogram is a word that has no repeating letters
// consecutive or non-consecutive. Implement a function
// that determines whether a string that contains only 
// letters is an isogram. Assume the empty string is an 
// isogram. Ignore letter case.

// Example: (Input-- > Output)

// "Dermatoglyphics"-- > true "aba"-- > false "moOse"-- > false(ignore letter case)

// isIsogram "Dermatoglyphics" = true
// isIsogram "moose" = false
// isIsogram "aba" = false




// My Solution ------------->


namespace Isograms
{

    public class Kata
    {
        public static bool IsIsogram(string str)
        {

            bool isTrue = true;

            for (int i = 0; i < str.Length ; i++)
            {
                for (int j = i; j < str.Length - 1 ; j++)
                {
                    if (str.ToLower()[i] == str.ToLower()[j + 1]) 
                    {
                        isTrue = false;
                    }
                }       
            }

            return isTrue;
       
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.IsIsogram("moos"));
            Console.ReadKey();         
        }
    }
}
