﻿// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

int res = SumNumber (number);
Console.WriteLine($"Сумма цифр в числе {res}");

int SumNumber (int num)
