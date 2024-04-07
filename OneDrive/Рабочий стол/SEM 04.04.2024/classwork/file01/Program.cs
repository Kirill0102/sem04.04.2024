// // Console.WriteLine("hello");
// Console.WriteLine("input number:");
// int a = Convert.ToInt32(Console.ReadLine());
// // System.Console.WriteLine(a * a);
// // System.Console.WriteLine("You input -> " + a * a);
// System.Console.WriteLine($"Quad of {a} -> {a * a}");


Console.WriteLine("input first number:");
int num1 = Convert.ToInt32(Console.ReadLine());//25
Console.WriteLine("input second number:");
int num2 = Convert.ToInt32(Console.ReadLine());//5

if (num1 == num2 * num2)
{
System.Console.WriteLine($"{num1} is squad of {num2}");
}
else
{
    System.Console.WriteLine($"{num1} is not squad of {num2}");
}