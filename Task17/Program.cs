﻿// Задача 17. Напишите программу, которая принимает на вход координаты точки (Х и Y),
// причём Х ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Clear();

Console.WriteLine("Введите X: ");
int X = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y: ");
int Y = int.Parse(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine("Номер четверти: 1");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Номер четверти: 2");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Номер четверти: 3");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("Номер четверти: 4");
}
else if (X == 0 || Y == 0)
{
    Console.WriteLine("На оси");
}