using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Write a function that removes the spaces 
// from the string, then return the resultant string.

// Examples:

// Input->Output
// "8 j 8   mBliB8g  imjB8B8  jl  B"-> "8j8mBliB8gimjB8B8jlB"
// "8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd"-> "88Bifk8hB8BB8BBBB888chl8BhBfd"
// "8aaaaa dddd r     "-> "8aaaaaddddr"



namespace Remove_String_Spaces
{
    public static class SpacesRemover
    {
        public static string NoSpace(string input)
        {

            string Result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsWhiteSpace(input[i]))
                {
                    input.Remove(i);
                }
                else
                {
                    Result += input[i];
                }
            }

            return Result;
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SpacesRemover.NoSpace("Hello World"));
            Console.ReadKey();
        }
    }
}
