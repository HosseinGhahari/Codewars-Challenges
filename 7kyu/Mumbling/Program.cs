using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This time no story, no theory. The examples
// below show you how to write function accum:

// Examples:

// accum("abcd")-> "A-Bb-Ccc-Dddd"
// accum("RqaEzty")-> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
// accum("cwAt")-> "C-Ww-Aaa-Tttt"
// The parameter of accum is a string which includes only letters from 



// My Solution :

namespace Mumbling
{
    public class Accumul
    {
        public static String Accum(string s)
        {
            StringBuilder result = new StringBuilder();
            for(int i = 0; i < s.Length; i++)
            {
                string repeat = new string(s[i], i + 1);
                string UpperLower = char.ToUpper(repeat[0]) + repeat.Substring(1).ToLower();  
                result.Append(UpperLower);

                if (i < s.Length - 1)
                {
                    result.Append("-");
                }
            }
        
            return result.ToString();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Accumul.Accum("abcd"));
            Console.ReadKey();
        }
    }
}
