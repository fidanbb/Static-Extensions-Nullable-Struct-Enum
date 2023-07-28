using System;
namespace Static_Extension_Enum_Nullable
{
	public static class Person
	{
		public static string Name { get; set; }

		public static  string Surname;

		public static void Test()
		{
			Console.WriteLine("Test method");
		}

		

		static Person()
		{
			Console.WriteLine("static constructor");
		}


   //     public Person()
   //     {
			//Console.WriteLine("no static condtructor");
   //     }

    }
}

