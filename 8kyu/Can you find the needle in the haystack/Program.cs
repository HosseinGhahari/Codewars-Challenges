using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Can you find the needle in the haystack?

// Write a function findNeedle() that takes an array full of junk but containing one "needle"

// After your function finds the needle it should return a message (as a string) that says:

// "found the needle at position " plus the index it found the needle, so:

// Example(Input-- > Output)

// ["hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk"] --> "found the needle at position 5"

// Note: In COBOL, it should return "found the needle at position 6"




// My Solution --------->



namespace Can_you_find_the_needle_in_the_haystack
{

    public class Kata
    {
        public static string FindNeedle(object[] haystack)
        {
            object id = 0;
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == "needle")
                {
                    id =  i;
                }
            }

            return $"found the needle at position {id}";
        }
    }



    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Kata.FindNeedle(new object[] { '3', "123124234", null, "hay", "world", "needle", 2, '3', true, false }));
            Console.ReadKey();
        }
    }
}
