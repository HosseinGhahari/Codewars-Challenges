using altERnaTIng_cAsE___ALTerNAtiNG_CaSe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


// altERnaTIng cAsE <=> ALTerNAtiNG CaSe
// Define String.prototype.toAlternatingCase 
// (or a similar function/method such as to_alternating_case/toAlternatingCase/ToAlternatingCase 
// in your selected language; see the initial solution for details) such that each lowercase
// letter becomes uppercase and each uppercase letter becomes lowercase. For example:

// "hello world".ToAlternatingCase() == "HELLO WORLD"
// "HELLO WORLD".ToAlternatingCase() == "hello world"
// "hello WORLD".ToAlternatingCase() == "HELLO world"
// "HeLLo WoRLD".ToAlternatingCase() == "hEllO wOrld"
// "12345".ToAlternatingCase() == "12345" // Non-alphabetical characters are unaffected
// "1a2b3c4d5e".ToAlternatingCase() == "1A2B3C4D5E"
// "String.ToAlternatingCase".ToAlternatingCase() == "sTRING.tOaLTERNATINGcASE"


// As usual, your function/method should be pure, 
// i.e. it should not mutate the original string.





// My Solution ----- >


namespace altERnaTIng_cAsE___ALTerNAtiNG_CaSe
{


    public static class StringExt
    {
        public static string ToAlternatingCase(this string Words)
        {
            
            
            string result = "";

            for (int i = 0; i < Words.Length; i++)
            {
                if (char.IsUpper(Words[i]))
                {
                    result += char.ToLower(Words[i]);
                }
                else 
                {
                    result += char.ToUpper(Words[i]);
                }
            }

            return result;

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("12a.2B3C}$4D5E".ToAlternatingCase());
            Console.ReadKey();
        }
    }
}
