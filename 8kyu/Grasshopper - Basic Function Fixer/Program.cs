using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Fix the function

// I created this function to add five to any number 
// that was passed in to it and return the new value.
// It doesn't throw any errors but it returns the wrong number.

// Can you help me fix the function?




// My Solution ------------------>


namespace Grasshopper___Basic_Function_Fixer
{

    public class Kata
    {
        public static int AddFive(int num)
        {
            // given code

            // int total = num + 5;
            // return num;


            // My Answer

               int total = num + 5;
               return total;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.AddFive(5));
            Console.ReadKey();
        }
    }
}
