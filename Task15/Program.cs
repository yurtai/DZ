// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите день недели: ");
int num = int.Parse(Console.ReadLine());
if (num == 6 || num == 7){
    Console.WriteLine("Это выходной день недели");
}else if (num < 1 || num > 7){
    Console.WriteLine("Такого дня недели нет!");
}else {
    Console.WriteLine("Это будний день недели");
}