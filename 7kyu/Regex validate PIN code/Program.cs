using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// ATM machines allow 4 or 6 digit PIN codes and
// PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.

// If the function is passed a valid PIN string, return true, else return false.

// Examples (Input --> Output)
// "1234"-- > true
// "12345"-- > false
// "a234"-- > false



// My Solution --------->


namespace Regex_validate_PIN_code
{

    public class Kata
    {
        public static bool ValidatePin(string pin)
        {
      
            bool check = true;

            if (!string.IsNullOrEmpty(pin))
            {
                for (int i = 0; i <= pin.Length - 1; i++)
                {
                    if ((char.IsDigit(pin[i])) && (pin.Length == 4 || pin.Length == 6))
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }
            }
            else
            {
                check = false;
            }
        
            if (check)
            {
                return check;
            }
            else 
            { 
                return check = false; 
            }


        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Kata.ValidatePin("1234"));
            Console.ReadKey();
        }
    }
}
