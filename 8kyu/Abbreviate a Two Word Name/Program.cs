using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a function to convert a name into initials.
// This kata strictly takes two words with one space in between them.

// The output should be two capital letters with a dot separating them.

// It should look like this:

// Sam Harris => S.H

// patrick feeney => P.F



// My Solution ------->



namespace Abbreviate_a_Two_Word_Name
{

    public class Kata
    {
        public static string AbbrevName(string name)
        {
            string[] arr = name.Split(' ');
            string Result = "";
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Result += arr[0].Substring(0,1);
                Result += ".";
                Result += arr[1].Substring(0,1);
            }

            return Result.ToUpper();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.AbbrevName("sam fisher"));
            Console.ReadKey();

        }
    }
}
