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
			Console.WriteLine("What is the number you want the factorial sum for?");
			string numberAsText = Console.ReadLine();
			int numberAsInteger = int.Parse(numberAsText);

			// Calculate
			int result = Calculator.CalculateFactorialSum(numberAsInteger);

			// Print
			Console.WriteLine("The result is " + result);

			Console.ReadLine();
		}
	}
}
