// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine ("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA>numberB){
    Console.WriteLine ($"Больше число A({numberA})");
}
else{
   Console.WriteLine ($"Больше число B({numberB})"); 
}