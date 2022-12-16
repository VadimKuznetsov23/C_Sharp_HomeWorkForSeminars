// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] newArray = GetArray(10, 100, 999);
PrintArray(newArray);
GetCount(newArray);
Console.WriteLine($"Количество четных чисел в массиве составляет: {GetCount(newArray)}");

int[] GetArray(int size, int minNum, int maxNum)
{
    int[] arr = new int[size];
    for(int i = 0; i < size; i ++)
    {
        arr[i] = new Random().Next(minNum, maxNum + 1);
    }
    return arr;
}
void PrintArray(int[] newarr)
{   
    Console.Write("[");
    for (int i = 0; i < newarr.Length; i ++)
    {
        if (i < newarr.Length - 1) 
        {
            Console.Write($"{newarr[i]}, ");
        }
        else Console.Write($"{newarr[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}
int GetCount(int[] res) //Метод производит подсчет четных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < res.Length; i++)
    {
        if(res[i] % 2 == 0)
        {
            count = count+ 1;
        }
    }
    return count;
}