using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Write a function which converts the input string to uppercase.


// My Solution ------ > 

public class Kata
{
    public static string MakeUpperCase(string str)
    {
       return str.ToUpper();
    }

}



namespace MakeUpperCase
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Kata.MakeUpperCase("hello")); 
            Console.ReadKey();

        }
    }
}
