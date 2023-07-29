using System;
namespace FactorialExtension.Extensions
{
	public static class CustomExtensions
	{
		public static int GetFactorial(this int num)
		{
			int fact = 1;

			for (int i = 1; i <= num; i++)
			{
				fact *= i;
			}

			return fact;
		}
	}
}

