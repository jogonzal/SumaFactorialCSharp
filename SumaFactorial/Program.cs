using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaFactorial
{
	class Program
	{
		static void Main(string[] args)
		{
			// Ask for number
			Console.WriteLine("What is the number you want the array to have?");
			string numberAsText = Console.ReadLine();
			int numberAsInteger = int.Parse(numberAsText);



			// Calculate
			//int[] result = Calculator.GetArrayWithNumbers(numberAsInteger);

			//for (int i = 0; i < result.Length; i++)
			//{
			//	Console.WriteLine("Number[" + i + "] = " + result[i]);
			//}

			Console.ReadLine();
		}
	}
}
