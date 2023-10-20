using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Create a function that gives a personalized greeting.
//This function takes two parameters: name and owner.

//Use conditionals to return the proper message:

//case                       return
//name equals owner         'Hello boss'
//otherwise                 'Hello guest'



// My Solution ------ >


namespace Grasshopper___Personalized_Message
{


    public class Kata
    {
        public static string Greet(string name, string owner)
        {
            
            if (name == owner)
            {
                return "Hello boss";
            }
            else
            {
                return "Hello guest";
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Kata.Greet("Jack", "Jack"));
            Console.ReadKey();
        }
    }
}
