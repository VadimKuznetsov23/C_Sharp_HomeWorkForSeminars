// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int[] newArray = GetArray(10, 1, 99);
PrintArrey(newArray);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна: {newArray}");
int[] GetArray (int size, int minNum, int maxNum)
{
    int[] arr = new int[size];
    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minNum, maxNum + 1);
    }
    return arr;
}
void PrinArray(int[] newarr)
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
}