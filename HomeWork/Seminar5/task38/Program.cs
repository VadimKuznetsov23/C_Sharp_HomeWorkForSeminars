// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] newArray = GetArray(10, 1, 99);
PrintArray(newArray);
PrintMAxMin(newArray);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива -> {GetDif(newArray)}");

double[] GetArray (int size, int minNum, int maxNum)
{
    double[] arr = new double[size];
    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next (minNum, maxNum + 1);
    }
    return arr;
}
void PrintArray(double[] newarr)
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
void PrintMAxMin(double[] res)// Выводит минимальное и максимальное число массива
{
    double maxRes = res[0];
    double minRes = res[0];
    for(int i = 0; i < res.Length; i ++)
    {
        if(maxRes < res[i]) maxRes = res[i];
        if(minRes > res[i]) minRes = res[i];
    }
    Console.WriteLine($"Минимальный элемент массива -> {minRes}");
    Console.WriteLine($"Максимальный элемент массива -> {maxRes}");
}
double GetDif(double[] dif) // Выводит разницу между максимальныи и минимальным числом массива
{
    double result = 0;
    double max = dif[0];
    double min = dif[0];
    for(int i = 0; i < dif.Length; i++)
    {
        if(max < dif[i]) max = dif[i];
        if (min > dif[i]) min = dif[i];
    }
    result = max - min;
    return result;
}