using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumaFactorial;

namespace SumaFactorialUnitTests
{
	[TestClass]
	public class CalculatorUnitTests
	{
		[TestMethod]
		public void TestNormalNumber1()
		{
			int result = Calculator.CalculateFactorialSum(5);
			Assert.AreEqual(15, result);
		}

		[TestMethod]
		public void TestNormalNumber2()
		{
			int result = Calculator.CalculateFactorialSum(3);
			Assert.AreEqual(6, result);
		}

		[TestMethod]
		public void TestNormalNumber3()
		{
			int result = Calculator.CalculateFactorialSum(-8);
			Assert.AreEqual(0, result);
		}

		[TestMethod]
		public void TestNormalNumber4()
		{
			int result = Calculator.CalculateFactorialSum(0);
			Assert.AreEqual(0, result);
		}
	}
}
