﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
namespace Correct_the_mistakes_of_the_character
{

    //Character recognition software is widely used to digitise printed texts
    //.Thus the texts can be edited, searched and stored on a computer.

    //When documents (especially pretty old ones written with a typewriter),
    //are digitised character recognition softwares often make mistakes.

    //Your task is correct the errors in the digitised text
    //You only have to handle the following mistakes:

    //S is misinterpreted as 5
    //O is misinterpreted as 0
    //I is misinterpreted as 1

    //The test cases contain numbers only by mistake.



    // My Solution ------------ >


    public class Kata
    {

        public static string Correct(string text)
        {

            return text.Replace('5', 'S').Replace('1', 'I').Replace('0', 'O');

        }



        class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine(Kata.Correct("L0ND0N"));
                Console.ReadKey();
            }
        }
    }
}
