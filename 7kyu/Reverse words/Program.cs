using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Complete the function that accepts a string parameter, and reverses 
//each word in the string. All spaces in the string should be retained.

//Examples
//"This is an example!" ==> "sihT si na !elpmaxe"
//"double  spaces"      ==> "elbuod  secaps"


// My Solution ------ >

namespace Reverse_words
{
    public static class Kata
    {
        public static string ReverseWords(string str)
        {


            //////////////// With List
            

            var list = new List<string>();
            string Result = "";

            foreach (string words in str.Split(' '))
            {
                list.Add(words);
            }

            for (int i = 0; i <= list.Count - 1; i++)
            {
                for (int j = list[i].Length - 1; j >= 0; j--)
                {
                    Result += list[i][j];
                }
                Result = Result + new string(' ', 1);
            }

            string End = Result.TrimEnd();
            return End;




            //////////////// With Array


        /*  string[] list = str.Split(' ');
            string Result = "";

            for (int i = 0; i <= list.Length - 1; i++)
            {
                for (int j = list[i].Length - 1; j >= 0; j--)
                {
                    Result += list[i][j] ;    
                }

                Result = Result + new string(' ', 1);
            }

            string End = Result.TrimEnd();

            return End;      */
        }



    }

    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(Kata.ReverseWords("This is a test"));
            Console.ReadKey();
        }
    }
}
