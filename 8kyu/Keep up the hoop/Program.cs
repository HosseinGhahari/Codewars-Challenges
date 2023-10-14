using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
