// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("input X:");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input Y:");
int Y = Convert.ToInt32(Console.ReadLine());

if(X > 0 && Y > 0)
{
    System.Console.WriteLine("1 четверть");
}

if(X > 0 && Y < 0)
{
    System.Console.WriteLine("4 четверть");
}

if(X < 0 && Y > 0)
{
    System.Console.WriteLine("2 четверть");
}

if(X < 0 && Y < 0)
{
    System.Console.WriteLine("3 четверть");
}