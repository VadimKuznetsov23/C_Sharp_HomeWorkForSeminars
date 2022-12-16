// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int[] newArray = GetArray(10, 1, 99);
PrintArray(newArray);
PrintMAxMin(newArray);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна: {GetDif(newArray)}");

int[] GetArray (int size, int minNum, int maxNum)
{
    int[] arr = new int[size];
    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minNum, maxNum + 1);
    }
    return arr;
}
void PrintArray(int[] newarr)
{
    Console.Write("[");
    for(int i = 0; i < newarr.Length; i++)
    {
        if (i < newarr.Length - 1)
        {
            Console.Write($"{newarr[i]}, ");
        }
        else Console.Write($"{newarr[i]}]");
    }
    Console.WriteLine();
}
void PrintMAxMin(int[] res)// Выводит минимальное и максимальное число массива
{
    int maxRes = res[0];
    int minRes = res[0];
    for(int i = 0; i < res.Length; i ++)
    {
        if(maxRes < res[i]) maxRes = res[i];
        if(minRes > res[i]) minRes = res[i];
    }
    Console.WriteLine($"Минимальный элемент массива -> {minRes}");
    Console.WriteLine($"Максимальный элемент массива -> {maxRes}");
}
int GetDif(int[] dif) // Выводит разницу между максимальныи и минимальным числом массива
{
    int result = 0;
    int max = dif[0];
    int min = dif[0];
    for(int i = 0; i < dif.Length; i++)
    {
        if(max < dif[i]) max = dif[i];
        if (min > dif[i]) min = dif[i];
    }
    result = max - min;
    return result;
}