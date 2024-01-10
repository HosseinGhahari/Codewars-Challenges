using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Complete the function/method so that it returns 
// the url with anything after the anchor (#) removed.

// Examples

// "www.codewars.com#about" --> "www.codewars.com"
// "www.codewars.com?page=1" -->"www.codewars.com?page=1"




// My Solution -------------->


namespace Remove_anchor_from_URL
{
    public static class Kata
    {
        public static string RemoveUrlAnchor(string url)
        {
            if (!url.Contains("#"))
            {
                return url;
            }
            return url.Substring(0 , url.IndexOf('#'));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.RemoveUrlAnchor("www.codewars.com/katas/"));
            Console.ReadKey();
        }
    }
}
