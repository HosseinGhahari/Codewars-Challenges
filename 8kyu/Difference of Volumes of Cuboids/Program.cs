using Difference_of_Volumes_of_Cuboids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


// In this simple exercise, you will create a
// program that will take two lists of integers,
// a and b.Each list will consist of 3 positive
// integers above 0, representing the dimensions
// of cuboids a and b. You must find the difference
// of the cuboids' volumes regardless of which is bigger.

// For example, if the parameters passed are
// ([2, 2, 3], [5, 4, 1]), the volume of a is 12 
// and the volume of b is 20. Therefore, the function should return 8.

// Your function will be tested with pre-made examples as well as random ones.

// If you can, try writing it in one line of code.





// My Solution -------------->



namespace Difference_of_Volumes_of_Cuboids
{
    public class Kata
    {
        public static int FindDifference(int[] a, int[] b)
        {
            int first = a.Aggregate(1, (c, d) => c * d);
            int Second = b.Aggregate(1, (g, m) => g * m);

            if (first > Second)
            {
                return (first - Second);
            }
            return Second - first;          
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.FindDifference(new int[] {2,3,5} , new int[] {1,4,4}));
            Console.ReadKey();
        }
    }
}
