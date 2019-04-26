using System;
using System.Numerics;

namespace euler_0020
{
	class Program
	{
		static void Main(string[] args)
		{
			long Base = 100;

			BigInteger factorial = Factorial(Base);
			BigInteger result = Sum(factorial);

			Console.WriteLine("Factorial is: " + factorial);
			Console.WriteLine("Result is: " + result);
			Console.ReadLine();
		}

		/// <summary>
		/// Sum of digits
		/// </summary>
		/// <param name="Number"></param>
		/// <returns></returns>
		private static BigInteger Sum(BigInteger Number)
		{
			long Result = 0;

			//string number = Number.ToString();

			foreach (char value in Number.ToString())
			{
				Result = Result + Int64.Parse(value.ToString());
			}

			return Result;
		}

		/// <summary>
		/// Factorial
		/// </summary>
		/// <param name="Number"></param>
		/// <returns></returns>
		private static BigInteger Factorial(System.Numerics.BigInteger Number)
		{
			BigInteger Result = 1;

			while (Number >= 1)
			{
				Result = Result * Number;
				Number--;
			}

			return Result;
		}
	}
}
