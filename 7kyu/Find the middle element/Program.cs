using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//As a part of this Kata, you need to create 
//a function that when provided with a triplet
//returns the index of the numerical element 
//that lies between the other two elements.

//The input to the function will be an 
//array of three distinct numbers (Haskell: a tuple).

//For example:

//gimme([2, 3, 1]) => 0

//2 is the number that fits between 1 and 3 and 
//the index of 2 in the input array is 0.

//Another example (just to make sure it is clear):

//gimme([5, 10, 14]) => 1

//10 is the number that fits between
//5 and 14 and the index of 10 in the input array is 1.





// My Solution --------------->


namespace Find_the_middle_element
{
    public class Kata
    {
        public static int Gimme(double[] inputArray)
        {
            double result = 0;
            List<double> list = new List<double>();
            for (int i = 0; i < inputArray.Length; i++)
            {
                list.Add(inputArray[i]);
            }
            Array.Sort(inputArray); 
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == inputArray[1])
                {
                    result = i;
                }
            }

            return Convert.ToInt32(result);
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Gimme(new double[] { 5, 10, 14 }));
            Console.ReadKey();
        }
    }
}
