using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Implement a function that accepts 3 integer values a, b, c. 
//The function should return true if a triangle can be built 
//with the sides of given length and false in any other case.

//(In this case, all triangles must have surface greater than 0 to be accepted).



// My Solution ------>



namespace Is_this_a_triangle
{

    public class Triangle
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            if (a + b > c && b + c > a && a + c > b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(Triangle.IsTriangle(5, 7, 10)); 
            Console.ReadKey();

        }
    }
}
