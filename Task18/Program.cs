// **Задача 18:** Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y)

// Console.Clear();

// Console.WriteLine("Введите номер четверти: ");
// int num = int.Parse(Console.ReadLine());

// if (num==1)
// {
//     Console.WriteLine("Диапазон возможных координат Х>0; Y>0");
// }
// else if (num==2)
// {
//     Console.WriteLine("Диапазон возможных координат Х<0; Y>0");
// }
// else if (num==3)
// {
//     Console.WriteLine("Диапазон возможных координат Х<0; Y<0");
// }
// else if (num==4)
// {
//     Console.WriteLine("Диапазон возможных координат Х>0; Y<0");
// }
// else
// {
//     Console.WriteLine("Введён неверный номер четверти");
// }



Console.Clear();

Console.WriteLine("Введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine());

switch(quarter)
{
    case 1:
    {
    Console.WriteLine("Диапазон возможных координат Х>0; Y>0");
    break;
    }
    case 2:
    {
    Console.WriteLine("Диапазон возможных координат Х<0; Y>0");
    break;
    }
    case 3:
    {
    Console.WriteLine("Диапазон возможных координат Х<0; Y<0");
    break;
    }
    case 4:
    {
    Console.WriteLine("Диапазон возможных координат Х>0; Y<0");
    break;
    }
    default:
    {
    Console.WriteLine("Введён неверный номер четверти");
    break;
    }
}