﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine ("Введите числа через запятую:");
string numbers = Console.ReadLine()!;
GetSum(numbers);

void GetSum(string message)
{
    string[] getNumbers = new string[message.Length];
    int z = 0;
    for (int i = 0; i < getNumbers.Length; i++)
    {
        if (message[i] == ',')
        {
            z++;
        }
        else
        {
            getNumbers[z] = getNumbers[z] + $"{message[i]}";
        }
    }
    z++;
    int[] convertNumbers = new int[z];
    Console.Write("[");
    for (int i = 0; i < convertNumbers.Length; i++)
    {
        convertNumbers[i] = Convert.ToInt32(getNumbers[i]);
        if(i < convertNumbers.Length-1)
        {
        Console.Write(convertNumbers[i] + ",  ");
        }
        else  Console.Write(convertNumbers[i] + "]");
    }
    int sum = 0;
    for (int i = 0; i < z; i++)
    {
        if (convertNumbers[i] > 0)
        {
            sum++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Количество чисел больше 0, введенных с клавиатуры -> {sum}");
}