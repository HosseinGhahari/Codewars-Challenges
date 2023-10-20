using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//This kata is about multiplying a given number by eight 
//if it is an even number and by nine otherwise.



// My Solution ------>


namespace Simple_multiplication
{

    public class Multiplier
    {
        public static int Multiply(int x)
        {
           if (x % 2 == 0)
           {
                return x * 8;
           }
           else
           {
                return x * 9;
           }

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiplier.Multiply(4));
            Console.ReadKey();


        }
    }
}
