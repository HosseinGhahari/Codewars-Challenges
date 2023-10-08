using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Create a function which answers the question "Are you playing banjo?".
//If your name starts with the letter "R" or lower case "r", you are playing banjo!

//The function takes a name as its only argument, and returns one of the following strings:

//name + " plays banjo"
//name + " does not play banjo"

//Names given are always valid strings.



// My Solution ---- >



namespace Are_You_Playing_Banjo
{

    public class Kata
    {
        public static string AreYouPlayingBanjo(string name)
        {
            if (name.StartsWith("R") ||  name.StartsWith("r"))
            {
               return $"{name} plays banjo";
            }
            else
            {
               return $"{name} does not play banjo";
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {

            var result = Kata.AreYouPlayingBanjo("Rick");
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
