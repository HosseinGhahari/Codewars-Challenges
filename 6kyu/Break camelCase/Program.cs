using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



//Complete the solution so that the function 
//will break up camel casing, using a space between words.

//Example

//"camelCasing"  =>  "camel Casing"
//"identifier"   =>  "identifier"
//""             =>  ""





// My Solution ------------------------->



namespace Break_camelCase
{

    public class Kata
    {
        public static string BreakCamelCase(string str)
        {


            // First Way of doing that ---------->

            string[] Words = Regex.Split(str, @"(?<!^)(?=[A-Z])");
            string text = "";
            for (int i = 0; i < Words.Length; i++)
            {
                text += Words[i] +  new string(' ', 1);
            }
            return text;




            // Second Way Of Doing That -------------- >

            string Text = "";

            for (int i = 0; i < str.Length; i++)
            {

                if (char.IsUpper(str[i]))
                {
                    Text += " ";
                }

               Text += str[i];
            }

            return Text;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.BreakCamelCase("camelCasingTest"));
            Console.ReadKey();
        }
    }
}
