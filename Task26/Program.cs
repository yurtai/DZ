﻿// Задача 26. Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

int res = Result(number);
Console.WriteLine($"Количество цифр в числе {res}");

int Result(int num)
{
    int ind = 0;

    while (num != 0)
    {
        num = num / 10;
        ind++;
    }
    return ind;
}