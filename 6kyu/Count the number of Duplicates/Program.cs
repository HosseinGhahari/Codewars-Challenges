using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Count the number of Duplicates
// Write a function that will return the 
// count of distinct case-insensitive 
// alphabetic characters and numeric digits 
// that occur more than once in the input string. 
// The input string can be assumed to contain only 
// alphabets (both uppercase and lowercase) and numeric digits.


// Example

// "abcde" -> 0 # no characters repeats more than once
// "aabbcde" -> 2 # 'a' and 'b'
// "aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
// "indivisibility" -> 1 # 'i' occurs six times
// "Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
// "aA11" -> 2 # 'a' and '1'
// "ABBA" -> 2 # 'A' and 'B' each occur twice





// My Solution ---------------->


namespace Count_the_number_of_Duplicates
{
    public class Kata
    {
        public static int DuplicateCount(string str)
        {

            List<char> list1 = new List<char>();
            List<char> list2 = new List<char>();
            list1 = str.ToLower().ToList();
  
            int counter = 0;
            for (int j = counter; j < list1.Count - 1; j++)
            {
                for (int i = counter; i < list1.Count - 1; i++)
                {
                    if (list1[counter] == list1[i + 1])
                    {
                        list2.Add(str[i + 1]);  
                    }              
                }
                counter++;
            }       
            ;
            return list2.Distinct().Count();

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.DuplicateCount("Indivisibilities"));
            Console.ReadKey();
        }
    }
}
