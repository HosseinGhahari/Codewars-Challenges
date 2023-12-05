using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




// You are going to be given a word. Your job is 
// to return the middle character of the word. 
// If the word's length is odd, return the middle character. 
// If the word's length is even, return the middle 2 characters.

// #Examples:
 
// Kata.getMiddle("test") should return "es"

// Kata.getMiddle("testing") should return "t"

// Kata.getMiddle("middle") should return "dd"

// Kata.getMiddle("A") should return "A"
// #Input

// A word (string) of length 0 < str < 1000 
// (In javascript you may get slightly more than 1000 
// in some test cases due to an error in the test cases). 
// You do not need to test for this. This is only here to 
// tell you that you do not need to worry about your solution timing out.

// #Output

// The middle character(s) of the word represented as a string.





// My Solution -------------------> 



namespace Get_the_Middle_Character
{
    public class Kata
    {
        public static string GetMiddle(string s)
        {

            string Even = "";
            string odd = "";

            if (s.Length % 2 == 0)
            {
                int start = (s.Length / 2) - 1;
                int end = (s.Length / 2);

                for (int i = start; i <= end; i++)
                {
                    Even += s[i];
                }
            }
            else
            {
                int start = (s.Length / 2) ;
                int end = (s.Length - start);

                for (int i = start ; i < end ; i++)
                {
                    odd += (s[i]);  
                }

                return odd;
            }

            return Even;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.GetMiddle("test"));
            Console.WriteLine(Kata.GetMiddle("testing"));
            Console.ReadKey();
        }
    }
}
