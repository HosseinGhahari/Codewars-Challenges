using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// Create a function that takes 2 integers in 
// form of a string as an input, and outputs 
// the sum (also as a string):

// Example: (Input1, Input2-- > Output)

// "4",  "5"-- > "9"
// "34", "5"-- > "39"
// "", ""-- > "0"
// "2", ""-- > "2"
// "-5", "3"-- > "-2"




// My Solution ----------->



namespace Sum_The_Strings
{

    public static class Sum
    {
        public static string StringsSum(string s1, string s2)
        {
            if (s1 == "" )
            {
                s1 = 0.ToString();
            }
            if (s2 == "")
            {
                s2 = 0.ToString();
            }

            int Answer = int.Parse(s1) + int.Parse(s2);
            return Answer.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum.StringsSum("",""));
            Console.ReadKey();
        }
    }
}
