using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Consider an array/list of sheep where some sheep may be missing from their place. 
//We need a function that counts the number of sheep present in the array (true means present).

//For example,

//[true, true, true, false,
//  true, true, true, true,
//  true, false, true, false,
//  true, false, false, true,
//  true, true, true, true,
//  false, false, true, true]
//The correct answer would be 17.

//Hint: Don't forget to check for bad values like null/undefined



// My Soution : ---->>





namespace Counting_sheep
{
    public static class Kata
    {
        public static int CountSheeps(bool[] sheeps)
        {
            int count = 0;

            if (sheeps.Length == 0)
            {
                return 0;
            }
            for (int i = 0; i < sheeps.Length; i++)
            {
                if (sheeps[i] == true)
                {
                    count++;
                }
            }

            return count;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            var sheeps = new bool[] { true, false, true };
            var result = Kata.CountSheeps(sheeps);
            Console.WriteLine($"The numbers of sheeps are : {result}");
            Console.ReadKey();
        }
    }
}
