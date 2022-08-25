
// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//
// int a = 10;
// Console.WriteLine("The number is {0}", a);
// Console.WriteLine($"The number is {a}");
//
// int b = 3;
// int c = ++b;
//
// Console.WriteLine($"b is {b} c is {c}");
//
// // for (int i = 0; i < 10; i++)
// // {
// //     Console.WriteLine($"{i}");
// // }
//
// Console.WriteLine(sizeof(Int64));

using MyCode;

Console.WriteLine("What is you age?");
string? input = Console.ReadLine();
try
{
    int age = int.Parse(input);
    Console.WriteLine($"You are {age} years old");
}
catch (OverflowException)
{
    Console.WriteLine("You age is a valid format but it is either to big or too small");
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.GetType()} says {ex.Message}");
}

Console.WriteLine(MyCode.MyCode.Sum(1,3));