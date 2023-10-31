using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Your task is simply to count the total number of lowercase letters in a string.

// Examples
// "abc" ===> 3

// "abcABC123" ===> 3

// "abcABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~" ===> 3

// "" ===> 0;

// "ABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~" ===> 0

// "abcdefghijklmnopqrstuvwxyz" ===> 26




// My Solution ------------->



namespace Regex_count_lowercase_letters
{

    public class Kata
    {
        public static int LowercaseCountCheck(string word)
        {
            
            int Count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLower(word[i]))
                {
                    Count++;
                }
            }

            return Count;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Kata.LowercaseCountCheck("abcABC123"));
            Console.ReadKey();

        }
    }
}
