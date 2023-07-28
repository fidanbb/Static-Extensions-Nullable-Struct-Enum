using System;
namespace Static_Extension_Enum_Nullable
{
	public class Animal
	{

       public void GetAge(int? age=null)
        {
            if (age==null)
            {
                Console.WriteLine("Age not found");
                return;

            }

            Console.WriteLine(age);
        }


    }
}

