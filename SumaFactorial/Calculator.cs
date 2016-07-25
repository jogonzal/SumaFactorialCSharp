using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaFactorial
{
	public class Calculator
	{
		public static int CalculateFactorialSum(int numberAsInteger)
		{
			int accumulator = 0;
			for (int i = 1; i < numberAsInteger + 1; i++)
			{
				accumulator += i;
			}
			return accumulator;
		}

		public static int SumOfArray(int[] arr)
		{
			int accumulator = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				int valor = arr[i];
				accumulator += valor;
			}
			return accumulator;
		}
	}
}
