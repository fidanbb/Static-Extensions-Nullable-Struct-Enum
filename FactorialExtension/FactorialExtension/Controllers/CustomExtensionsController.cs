using System;
using FactorialExtension.Extensions;
using FactorialExtension.Helpers;

namespace FactorialExtension.Controllers
{
	public class CustomExtensionsController
	{
		public void GetFactorial()
		{
            Console.WriteLine("Add your number");
            int num;

        Num: bool isNumber = int.TryParse(Console.ReadLine(), out num);

            if (isNumber)
            {
                if (num >= 1)
                {
                    Console.WriteLine($"Factorial of {num} is equal to {num.GetFactorial()}");
                }

                else if (num == 0)
                {
                    Console.WriteLine(FacorialMessages.FactOfZero);
                }

                else
                {
                    Console.WriteLine(FacorialMessages.FactOfNegatives);
                }

            }

            else
            {
                Console.WriteLine(FacorialMessages.FactFailed);
                goto Num;
            }
        }
	}
}

