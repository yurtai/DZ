﻿// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumber = SumNumber(number);

Console.WriteLine("Сумма цифр в числе: " + sumNumber);

int SumNumber(int number)
{

    int counter = Convert.ToString(number).Length;
    int num = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        num = number - number % 10;
        result = result + (number - num);
        number = number / 10;
    }
    return result;
}
