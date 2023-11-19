using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Simple, given a string of words, 
// return the length of the shortest word(s).

// String will never be empty and you do not need 
// to account for different data types.



// My Solution ---------- >


namespace Shortest_Word
{
    public class Kata
    {
        public static int FindShort(string s)
        {

            string[] list = s.Split(' ');
            int count = list[0].Length;
            for (int i = 1; i <= list.Length - 1; i++)
            {
                if (list[i].Length < count)
                {
                    count = list[i].Length;
                }
            }

            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.FindShort("bitcoin take over the world maybe who knows perhaps"));
            Console.ReadKey();
        }
    }
}
