using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Create a function that accepts a string 
// and a single character, and returns an 
// integer of the count of occurrences the 
// 2nd argument is found in the first one.

// If no occurrences can be found, a 
// count of 0 should be returned.

// ("Hello", "o")  ==> 1
// ("Hello", "l") ==> 2
// ("", "z") ==> 0

// str_count("Hello", 'o'); // returns 1
// str_count("Hello", 'l'); // returns 2
// str_count("", 'z'); // returns 0





// My Solution ---------------- >


namespace All_Star_Code_Challenge__18
{
    class Kata
    {
        public static int StrCount(string str, char letter)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == letter)
                {
                    count++;
                }
                else
                {
                    return 0;
                }
            }

            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.StrCount("Hello",'l'));
            Console.ReadKey();
        }
    }
}
