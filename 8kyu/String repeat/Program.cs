using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a function that accepts an integer n and a
//string s as parameters, and returns a string of s
//repeated exactly n times.

//Examples (input -> output)

//6, "I"-> "IIIIII"
//5, "Hello"-> "HelloHelloHelloHelloHello"




// My Solution ---------->


namespace String_repeat
{
    
    class Program
    {

        public static class Kata
        {
            public static string RepeatStr(int n, string s)
            {

                string Result = "";

                for (int i = 0; i < n; i++)
                {
                    Result += s;
                }

                return Result;

            }
        }


        static void Main(string[] args)
        {

            Console.WriteLine(Kata.RepeatStr(4,"#"));
            Console.ReadKey();

        }

    }
}
