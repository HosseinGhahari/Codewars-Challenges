using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// Trolls are attacking your comment section!

// A common way to deal with this situation is 
// to remove all of the vowels from the trolls' 
// comments, neutralizing the threat.

// Your task is to write a function that takes 
// a string and return a new string with all vowels removed.

// For example, the string "This website is for losers LOL!" 
// would become "Ths wbst s fr lsrs LL!".

// Note: for this kata y isn't considered a vowel.




// My Solution ---------------------->


namespace Disemvowel_Trolls
{
    public static class Kata
    {
        public static string Disemvowel(string str)
        {

            var Vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            string Words = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (!Vowels.Contains(str.ToLower()[i]))
                {
                    Words += str[i];
                }
            }

            return Words;

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Disemvowel("This website is for losers LOL!"));
            Console.ReadKey();
        }
    }
}
