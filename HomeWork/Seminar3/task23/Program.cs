﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Для вывода таблицы кубов чисел от 1 до введенного числа введите число: ");
int n = int.Parse(Console.ReadLine()!);

for(int i = 1; i <= n; i++)
{
    if(i!=0)
    {int sum = i*i*i;
    Console.Write(" " + sum);}
    else Console.Write("0");
}