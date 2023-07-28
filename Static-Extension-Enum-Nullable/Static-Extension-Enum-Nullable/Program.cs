
using Static_Extension_Enum_Nullable;
using Static_Extension_Enum_Nullable.Extensions;

//Person.Name = "Kubra";
//Console.WriteLine(Person.Name);

//Person.Test();

//Person person = new Person();
//Person person1 = new Person();
//Person person2 = new Person();
//Person person3 = new Person();

//Car car1 = new Car();
//Car car2 = new Car();
//Car car3 = new Car();

//Console.WriteLine(Car.count);

//int num = 50;
//int result = num.Sum(100);

//Console.WriteLine(result);

//string name = "Fidan66@";

//Console.WriteLine(name.HasStr("d"));

//Console.WriteLine(name.CheckDigitOfString(@"\d"));
//Console.WriteLine(name.CheckDigitOfString(@"@"));

//Console.WriteLine(name.CheckDigitOfString(@"[A-Z] [a-z]"));

//Book book = new();

//book.Name = "Xosrov ve Shirin";

//book.Test();

//string name = null;

//Console.WriteLine(name);


//int? age = null;

//if (age==null)
//{
//    Console.WriteLine("Age not found");
//}

//Animal animal = new Animal();

//animal.GetAge();


//GetRole(1);

//static void GetRole(int roleId)
//{
//    if (roleId==(int)Roles.SuperAdmin)
//    {
//        Console.WriteLine("SuperAdmin");
//    }
//}

//CheckRole(4);

//static void CheckRole(int roleId)
//{
//    switch (roleId)
//    {
//        case (int)Roles.SuperAdmin:
//            Console.WriteLine("SuperAdmin");
//            break;
//        case (int)Roles.Admin:
//            Console.WriteLine("Admin");
//            break;
//        case (int)Roles.Member:
//            Console.WriteLine("Member");
//            break;
//        default:
//            Console.WriteLine("Role id is wrong");
//            break;
//    }
//}

//foreach (var item in Enum.GetValues(typeof(Roles)))
//{
//    Console.WriteLine(item.ToString());
//}


//HasRole("Adminf");

//static void HasRole(string role)
//{
//    foreach (var item in Enum.GetValues(typeof(Roles)))
//    {
//        if (item.ToString()==role)
//        {
//            Console.WriteLine("Yes, we have this role");
//            return;
//        }
//    }
//}


//static void HasRole(string role)
//{
//    bool hasRole=false;

//    foreach (var item in Enum.GetValues(typeof(Roles)))
//    {
//        if (item.ToString() == role)
//        {
//            hasRole = true;
//        }
//    }

//    if (hasRole)
//    {
//        Console.WriteLine("Yes, we have this role");
//    }

//    else
//    {
//        Console.WriteLine("No, we dont have this role");
//    }
//}


//var result = HasRole("Adminf"); ;

//static bool HasRole(string role)
//{

//    foreach (var item in Enum.GetValues(typeof(Roles)))
//    {
//        if (item.ToString() == role)
//        {
//            return true;
//        }
//    }

//    return false;
//}

//if (result)
//{
//    Console.WriteLine("Yes, we have this role");
//}
//else
//{
//    Console.WriteLine("No, we dont have this role");
//}

var result = HasRole("Admin");

Console.WriteLine(result);

static string HasRole(string role)
{
   

    foreach (var item in Enum.GetValues(typeof(Roles)))
    {
        if (item.ToString() == role)
        {
            return "Yes, we have this role";
        }
    }

    return "No, we dont have this role";
}