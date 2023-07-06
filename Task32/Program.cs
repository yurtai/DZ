// Задача 32. Напишите программу замена элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.

int []GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int [size];
    for (int i = 0; i < size; i++)
    {
            result[i]=new Random().Next (minValue,maxValue +1);
    } 
    return result;
}
int[] arr = GetRandomArray (6,-9,9);
for (int i = 0; i < arr.Length; i++)
{
    arr[i]*=-1;
}
Console.WriteLine(string.Join(", ", arr));