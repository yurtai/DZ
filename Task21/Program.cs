// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Clear();

// Console.WriteLine("Введите X1: ");
// double x1 = double.Parse(Console.ReadLine());
// Console.WriteLine("Введите Y1: ");
// double y1 = double.Parse(Console.ReadLine());
// Console.WriteLine("Введите Z1: ");
// double Z1 = double.Parse(Console.ReadLine());

// Console.WriteLine("Введите X2: ");
// double x2 = double.Parse(Console.ReadLine());
// Console.WriteLine("Введите Y2: ");
// double y2 = double.Parse(Console.ReadLine());
// Console.WriteLine("Введите Z2: ");
// double z2 = double.Parse(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow(y1-y2,2) + Math.Pow(Z1-z2,2));

// Console.WriteLine($"d={d:f2}");


Console.Clear();

Console.WriteLine("Введите X1: ");
double X1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите X2: ");
double X2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите X3: ");
double X3 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите Y1: ");
double Y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Y2: ");
double Y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Y3: ");
double Y3 = double.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((X1-Y1),2) + Math.Pow(X2-Y2,2) + Math.Pow(X3-Y3,2));

Console.WriteLine($"d={result:f2}");