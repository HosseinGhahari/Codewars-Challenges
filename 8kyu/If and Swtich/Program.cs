
using If_and_Swtich;

namespace IfAndSwitch
{
    class program
    {


        static void Main(string[] args)
        {

            var IfSeason = Season.Winter;

/*
            if (IfSeason == Season.Summer)
            {
                Console.WriteLine("It's Hot");
            }
            else if (IfSeason == Season.Winter)
            {
                Console.WriteLine("It's Cold");
            }
            else
            {
                Console.WriteLine("Let go man");
            }
*/



            //////// with switch 
            ///



            switch (IfSeason)
            {
                case Season.Winter:

                    Console.WriteLine("it's cold");
                    break;

                case Season.Summer:
                    Console.WriteLine("it's hot");
                    break;

                default:
                    Console.WriteLine("Dman");
                    break;

            }







        }


    }


}