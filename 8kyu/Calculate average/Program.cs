using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a function which calculates the average of the numbers in a given list.

//Note: Empty arrays should return 0.


// My Solution ------ >


namespace Calculate_average
{

    class AverageSolution
    {
        public static double FindAverage(double[] array)
        {
            double result = 0;

            if (array.Length == 0)
            { 
                return 0; 
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    result += array[i];
                }

                result /= array.Length;
                return result;
            }
           
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            double[] array = new double[]{ 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 };
            Console.WriteLine(AverageSolution.FindAverage(array));
            Console.WriteLine(AverageSolution.FindAverage(new double[] {}));
            Console.ReadKey();
        }
    }
}
