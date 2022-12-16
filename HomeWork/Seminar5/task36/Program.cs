// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] newArray = GetArray(10, 1, 999);
PrintArray(newArray);
int[] GetArray(int size, int miNum, int maxNum)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(miNum, maxNum + 1);
    }
    return res;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1)
        {
            Console.Write($"{arr[i]}, ");
        }
        else Console.Write($"{arr[i]}]");
    }
}