using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Terminal game move function
//In this game, the hero moves from left to right. 
//The player rolls the dice and moves the number of
//spaces indicated by the dice two times.

//Create a function for the terminal game that takes 
//the current position of the hero and the roll (1-6) 
//and return the new position.

//Example:
//move(3, 6) should equal 15





// My Solution ---------------------------->


namespace Terminal_game_move_function
{
    public class Game
    {
        public static int Move(int position, int roll)
        {
            return (roll * 2) + position;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write(Game.Move(3, 6));
            Console.ReadKey();
        }
    }
}
