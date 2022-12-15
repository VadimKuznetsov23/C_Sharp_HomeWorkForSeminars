// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] GetArray(int size, int minNum, int maxNum)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minNum, maxNum + 1);
    }
    return res;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");           
        else Console.Write($"{arr[i]}");
    }
     Console.Write("]");
}

int [] newArray = GetArray(8, 1, 100);
PrintArray(newArray);
