// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

using System.Globalization;

Console.WriteLine("input three-digit number:");
int n = Convert.ToInt32(Console.ReadLine());


if(n >= 100 && n <= 999)
{
    int b = n % 10;
    int y = n / 100;
    System.Console.WriteLine($"Sum of {b} and {y} -> {b + y}");
}
else
{
 System.Console.WriteLine("You input not three-digit number");
}



