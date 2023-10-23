using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

// Deoxyribonucleic acid(DNA) is a chemical found in
// the nucleus of cells and carries the "instructions" 
// for the development and functioning of living organisms.

// If you want to know more: http://en.wikipedia.org/wiki/DNA

// In DNA strings, symbols "A" and "T" are complements of each 
// other, as "C" and "G". Your function receives one side of the DNA 
// (string, except for Haskell); you need to return the other 
// complementary side. DNA strand is never empty or there is 
// no DNA at all (again, except for Haskell).

// More similar exercise are found here: http://rosalind.info/problems/list-view/ (source)

// Example: (input-- > output)

// "ATTGC"-- > "TAACG"
// "GTAT"-- > "CATA"



// My Solution ------>


namespace Complementary_DNA
{

    public class DnaStrand
    {
        public static string MakeComplement(string dna)
        {

            char[] words = dna.ToCharArray();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == 'A')
                {
                    words[i] = 'T';
                }
                else if (words[i] == 'T')
                {
                    words[i] = 'A';
                }
                else if (words[i] == 'G')
                {
                    words[i] = 'C';
                }
                else if (words[i] == 'C')
                {
                    words[i] = 'G';
                }
            }

            return new string(words);

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DnaStrand.MakeComplement("ATTGC")); // -- TAACG
            Console.ReadKey();
        }
    }
}
