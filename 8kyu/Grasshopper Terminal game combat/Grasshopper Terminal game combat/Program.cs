using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// Create a combat function that takes the player's 
// current health and the amount of damage recieved, 
// and returns the player's new health.Health can't be less than 0.



// My Solution --------->



namespace Grasshopper_Terminal_game_combat
{
    public static class Game
    {
        public static float Combat(float health, float damage)
        {
            if (health < damage)
            {
                return 0;
            }
            return health - damage;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Game.Combat(100,50));
            Console.ReadKey();
        }
    }
}
