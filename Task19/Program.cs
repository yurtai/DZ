// // Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да


// Console.WriteLine("Введите пятизначное число число : ");
// string number = (Console.ReadLine());

// if (number.Length !=5) {
// Console.Write ("Число не пятизначное!");
// return;
// }

// if (number[0]==number[4] && number[1]==number[3]){
//     Console.WriteLine("Да, является палиндромом");
// }else{
//     Console.WriteLine("Нет, не является палиндромом");
// }   


// Console.WriteLine("Введите пятизначное число число : ");
// string number = (Console.ReadLine());

// bool (number.Length !=5) {
// Console.Write ("Число не пятизначное!");
// return;
// }
// bool result = (number[0]==number[4] && number[1]==number[3]);
// Console.WriteLine(result);


Console.WriteLine("Введите пятизначное число: ");
string input = Console.ReadLine();

if (input.Length != 5)
{
    Console.WriteLine("Число не пятизначное!");
    return;
}

bool result = (input[0] == input[4] && input[1] == input[3]);
Console.WriteLine(result);

