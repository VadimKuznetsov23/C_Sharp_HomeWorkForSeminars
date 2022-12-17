// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string ReadLine(string message)
{Console.WriteLine(message);
return Console.ReadLine()!;
}
int[] GetNum(string message)
{
    int[] arr = new int[message.Length];
    for(int i = 0; i < message.Length; i++)
    {
        arr[i] = message[0];
    }
    return arr;
}
void PrintArray(int[] res)
{
    for(int i = 0; i < res.Length; i++)
    {
        Console.Write($"{res[i]} ");
    }
}
string numbers = ReadLine("Введите любое число");
// int[] neArr = GetNum(numbers);
// PrintArray(neArr);
Console.Write(numbers[1]);
