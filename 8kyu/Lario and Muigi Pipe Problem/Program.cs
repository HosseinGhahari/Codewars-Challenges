using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


// Issue
 
// Looks like some hoodlum plumber and his brother 
// has been running around and damaging your stages again.

// The pipes connecting your level's stages together
// need to be fixed before you receive any more complaints.

// The pipes are correct when each pipe after the first
// is 1 more than the previous one.

// Task
// Given a list of unique numbers sorted in ascending order,
// return a new list so that the values increment by 1 for each
// index from the minimum value up to the maximum value (both included).

// Example
// Input:  1,3,5,6,7,8 Output: 1,2,3,4,5,6,7,8




// My Solution --------- >


namespace Lario_and_Muigi_Pipe_Problem
{

    public class Fixer
    {
        public static List<int> PipeFix(List<int> numbers)
        {

            var MyList = new List<int>();
            MyList.Add(numbers[0]);
            int count = numbers.Last() - numbers.First();

            for (int i = 1; i <= count; i++)
            {
                MyList.Add(numbers[0] + i);
            }

            return MyList; 
         
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fixer.PipeFix(new List<int> { 1, 6 }));
            Console.ReadKey();
        }
    }
}
