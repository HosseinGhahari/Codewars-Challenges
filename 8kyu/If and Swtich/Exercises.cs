using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_and_Swtich
{
    class Exercises
    {


        

          static void Main(string[] args)

          {


            //// E1


            /*   int number;
                 Console.WriteLine("Enter a number : ");
                 number = Convert.ToInt32(Console.ReadLine());

                 if (number >= 1 &&  number <= 10) 
                 {

                     Console.WriteLine("valid");

                 }
                 else
                 {
                     Console.WriteLine("Invalid");
                 }
   */




            /////// E2


            /*int num1;
            int num2;

            Console.WriteLine("Enter 1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1 + " is bigger ");
            }
            else
            {
                Console.WriteLine(num2 + " is bigger");
            }*/




            /////// E3


            /*int Width;
            int Height;

            Console.WriteLine("Enter Width");
            Width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Height");
            Height = Convert.ToInt32(Console.ReadLine());   


            if (Width > Height)
            {
                Console.WriteLine("It's Landscape");
            }
            else
            {
                Console.WriteLine("It's Potrate");
            }*/



            int SpeedLimit;
            int CarSpeed;
            int demerit = 1;
            int result;
            Console.WriteLine("Enter Speed Limit : ");
            SpeedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Speed of the car : ");
            CarSpeed = Convert.ToInt32(Console.ReadLine());

            if (CarSpeed < SpeedLimit)
            {
                Console.WriteLine("Nice Driving");
            }

            else if (CarSpeed > SpeedLimit)
            {

                result = CarSpeed - SpeedLimit;
                demerit = result / 5;
                Console.WriteLine("Number of Demerit is : " + demerit);

            }
            
            if (demerit > 12)
            {
                Console.WriteLine("Your license is Captured");
            }



        }












    }
}
