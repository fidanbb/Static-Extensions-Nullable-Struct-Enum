using System;
using System.Text.RegularExpressions;

namespace Static_Extension_Enum_Nullable.Extensions
{
	public static  class CustomExtensions
	{

        public static int Sum(this int number,int num2)
        {
            return number + num2;
        }

        public static bool HasStr(this string text, string search)
        {
            return text.Contains(search);
        }

        public static bool CheckDigitOfString(this string str,string pattern)
        {
            return Regex.IsMatch(str, pattern);
        }

        public static void Test(this Book book)
        {
            Console.WriteLine(book.Name);
        }
    }
}

