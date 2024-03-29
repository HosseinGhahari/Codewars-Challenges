﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//There is an array with some numbers. 
//All numbers are equal except for one.
//Try to find it!

//findUniq([ 1, 1, 1, 2, 1, 1 ]) === 2
//findUniq([0, 0, 0.55, 0, 0]) === 0.55

//It’s guaranteed that array contains at least 3 numbers.

//The tests contain some very huge arrays, so think about performance.

//This is the first kata in series:





// My Solution --------------------------->


namespace Find_the_unique_number
{

	public class Kata
	{
		public static int GetUnique(IEnumerable<int> numbers)
		{
			int hold = 0;
			int result = 0;
			int[] num = numbers.ToArray();
			Array.Sort(num);

			if (num[0] != num[1])
			{
				result = num[0];
				return result;	
			}
			else
			{
				hold = num[0];
				var numbs = numbers.Distinct().ToArray();

				if (numbs[0] == hold)
				{
					result = numbs[1];
				}
			}

			return result;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Kata.GetUnique(new int[] { 11, 11, 14, 11, 11 }));
			Console.ReadKey();
		}
	}
}
