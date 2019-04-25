using System;

namespace euler_0020
{
	class Program
	{
		static void Main(string[] args)
		{
			long Base = 20;

			string factorial = Factorial(Base);
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
		private static long Sum(string Number)
		{
			long Result = 0;

			//string number = Number.ToString();

			foreach (char value in Number)
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
		private static string Factorial(long Number)
		{
			string Result = "1";

			while (Number >= 1)
			{
				Result = Multipler(Result, Number.ToString());
				Number--;
			}

			return Result;
		}

		public static string Multipler(string Value1, string Value2)
		{
			var maxLength = Math.Max(Value1.Length, Value2.Length);
			var workLength = maxLength * 2;

			var line1 = new String('0', workLength - Value1.Length);
			var line2 = new String('0', workLength - Value2.Length);
			char[] line3 = new char[workLength];

			line1 = line1 + Value1;
			line2 = line2 + Value2;

			for (var x = workLength - 1; x > 0; x--)
			{
				var val1 = int.Parse(line1[x].ToString());
				var val2 = int.Parse(line2[x].ToString());
				var currentResult = val1 * val2;
				var decimals = 0;
				var digits = currentResult;
				var currentSegment = 0;
				// var tempVal = line3[x];
				if ('\0' != line3[x])
				{
					currentSegment = int.Parse(line3[x].ToString());
				}
				var nextSegment = 0;
				if (line3[x - 1] != '\0')
				{
					nextSegment = int.Parse(line3[x - 1].ToString());
				}
				currentResult = currentResult + currentSegment + (nextSegment * 10);
				if (currentResult >= 10)
				{
					decimals = int.Parse(currentResult.ToString()[0].ToString());
					digits = int.Parse(currentResult.ToString()[1].ToString());

					line3[x] = digits.ToString()[0];
					line3[x - 1] = decimals.ToString()[0];
				}
				else
				{
					line3[x] = currentResult.ToString()[0];
				}

				line3[x] = digits.ToString()[0];
			}

			Console.WriteLine(line3.ToString());

			return line3.ToString();
		}
	}
}
