using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Given an array of integers, return a 
//new array with each value doubled.

//For example:

//[1, 2, 3]-- > [2, 4, 6]





// My Solution ---------------------->


namespace Beginner___Lost_Without_a_Map
{
    public class Kata
    {
        public static int[] Maps(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = x[i] * 2;
            }
            return x;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            foreach(var item in Kata.Maps(new int[] { 2, 4, 6 }))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
