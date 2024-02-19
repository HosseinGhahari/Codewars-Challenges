using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//In this kata you will create a function that
//takes a list of non-negative integers and
//strings and returns a new list with the strings 
//filtered out.



//Example

//ListFilterer.GetIntegersFromList(new List<object>() { 1, 2, "a", "b" }) => { 1, 2}
//ListFilterer.GetIntegersFromList(new List<object>() { 1, 2, "a", "b", 0, 15 }) => { 1, 2, 0, 15}
//ListFilterer.GetIntegersFromList(new List<object>(){1,






// My Solution --------------------------->


namespace List_Filtering
{
	public class ListFilterer
	{
		public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
		{

			//// Linq Way 
			List<int> NumericList = new List<int>();
			NumericList = listOfItems.OfType<int>().ToList();
			return NumericList;



			//Normal Way
			List<int> NumericList = new List<int>();

			foreach (object item in listOfItems)
			{
				if (item is int)
				{
					NumericList.Add((int)item);
				}
			}

			return NumericList;
		}
	}


	class Program
	{
		static void Main(string[] args)
		{
			foreach(var items in ListFilterer.GetIntegersFromList(new List<object>() { 1, 2, "aasf", "1", "123", 123 }))
			{
				Console.WriteLine(items);
			}
			Console.ReadKey();
		}
	}
}
