using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Bob needs a fast way to calculate the volume of a 
// cuboid with three values: the length, width and 
// height of the cuboid. Write a function to help 
// Bob with this calculation.



// My Solution ------>

namespace Volume_of_a_Cuboid
{

    public class Kata
    {
        public static double GetVolumeOfCuboid(double length, double width, double height)
        {
            return length * width * height;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.GetVolumeOfCuboid(2,5,6));
            Console.ReadKey();
        }
    }
}
