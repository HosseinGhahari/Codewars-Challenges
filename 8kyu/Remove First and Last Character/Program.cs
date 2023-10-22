using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// It's pretty straightforward. Your goal is to create a function 
// that removes the first and last characters of a string. 
// You're given one parameter, the original string. You don't 
// have to worry with strings with less than two characters.



// My Solution ------ >



namespace Remove_First_and_Last_Character
{

    public class Kata
    {
        public static string Remove_char(string s)
        {

            // Solution 1 

            return s.Remove(0, 1).Remove(s.Length - 2, 1);





            // Solution 2 - indeed it does not remove just ignore the first and last


            /*string Result = "";
            for (int i = 1; i < s.Length - 1; i++)
            {
                Result += s[i];
            } 

            return Result;*/


        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Remove_char("Hello"));
            Console.ReadKey();
        }
    }
}
