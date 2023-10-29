using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Rock Paper Scissors

// Let's play! You have to return which player won! In case of a draw return Draw!.

// Examples(Input1, Input2 --> Output):

// "scissors", "paper"-- > "Player 1 won!"
// "scissors", "rock"-- > "Player 2 won!"
// "paper", "paper"-- > "Draw!"



// My Solution -------->


namespace Rock_Paper_Scissors_
{
    public class Kata
    {
        public string Rps(string p1, string p2)
        {

            if ((p1 == "scissors" && p2 == "paper") || (p1 == "paper" && p2 == "rock") || (p1 == "rock" && p2 == "scissors"))
            {
                return "Player 1 won!";
            }
            else if (p1 == p2)
            {
                return "Draw!";
            }
            else
            {
                return "Player 2 won!";
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Kata kata = new Kata();
            Console.WriteLine(kata.Rps("scissors", "paper"));
            Console.ReadKey();
        }
    }
}
