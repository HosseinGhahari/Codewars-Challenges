using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Alex just got a new hula hoop, he loves it but feels
//discouraged because his little brother is better than him

//Write a program where Alex can input (n) how many times
//the hoop goes round and it will return him an encouraging message :)

//If Alex gets 10 or more hoops, return the string "Great, now move on to tricks".
//If he doesn't get 10 hoops, return the string "Keep at it until you get it".



// My Solution ---- >


namespace Keep_up_the_hoop
{

    public class Kata
    {
        public static string HoopCount(int Number)
        {

            string WinMessage = "Great, now move on to tricks";
            string TryAgainMessage = "Keep at it until you get it";
            if (Number >= 10)
            {
                return WinMessage;
            }
            else
            {
                return TryAgainMessage;
            }
            
        }
    }



    class Program
    {
        static void Main(string[] args)
        {

           Console.WriteLine(Kata.HoopCount(10));
           Console.ReadKey();

        }
    }
}
