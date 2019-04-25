using System;

namespace euler_0020
{
	class Program
	{
		static void Main(string[] args)
		{
			long Base = 100;

			long factorial = Factorial(Base);
			long result = Sum(factorial);

			Console.WriteLine("Factorial is: " + factorial);
			Console.WriteLine("Result is: " + result);
			Console.ReadLine();
		}

		/// <summary>
		/// Sum of digits
		/// </summary>
		/// <param name="Number"></param>
		/// <returns></returns>
		private static long Sum(long Number)
		{
			long Result = 0;

			string number = Number.ToString();

			foreach (char value in number)
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
		private static long Factorial(long Number)
		{
			long Result = 1;

			while (Number >= 1)
			{
				Result = Result * Number;
				Number--;
			}

			return Result;
		}
	}
}
