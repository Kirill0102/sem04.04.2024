// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine("input first number:");
int num1 = Convert.ToInt32(Console.ReadLine());

if(num1 % 7 == 0 && num1 % 23 == 0)
{
    System.Console.WriteLine(num1);
}
else
{
    System.Console.WriteLine("Число не кратно 7 и 23 одновременно");
}