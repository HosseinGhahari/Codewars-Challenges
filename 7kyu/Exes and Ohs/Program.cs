using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Check to see if a string has the same amount 
// of 'x's and 'o's. The method must return a 
// boolean and be case insensitive. The string 
// can contain any char.

// Examples input/output:

// XO("ooxx") => true
// XO("xooxx") => false
// XO("ooxXm") => true
// XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
// XO("zzoo") => false



// My Soultions ----------------- >


namespace Exes_and_Ohs
{

    public static class Kata
    {
        public static bool XO(string input)
        {

            // Solution 1 

            int Xholder = 0;
            int Oholder = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if ((input[i] == 'x' || input[i] == 'X')  || input[i] == 0)
                {
                    Xholder++;
                }
                else if ((input[i] == 'o' || input[i] == 'O') || input[i] == 0)
                {
                    Oholder++;
                }
            }

            if (Xholder == Oholder)
            {
                return true;
            }
            return false;




            // Solution 2 with Lambda Expressions

            // return input.ToLower().Count(i => i == 'x') == input.ToLower().Count(i => i == 'o');
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.XO("Oo"));
            Console.ReadKey();
        }
    }
}
