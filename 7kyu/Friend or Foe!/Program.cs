using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Make a program that filters a list of strings 
// and returns a list with only your friends name in it.

// If a name has exactly 4 letters in it, you can 
// be sure that it has to be a friend of yours! 
// Otherwise, you can be sure he's not...

// Ex: Input = ["Ryan", "Kieran", "Jason", "Yous"], Output = ["Ryan", "Yous"]

// i.e.

// friend["Ryan", "Kieran", "Mark"] `shouldBe` ["Ryan", "Mark"]




// My Solution ---------------->


namespace Friend_or_Foe_
{

    public static class Kata
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            return names.Where(n => n.Length == 4);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" , "jack" };

            foreach (string name in Kata.FriendOrFoe(names))
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}
