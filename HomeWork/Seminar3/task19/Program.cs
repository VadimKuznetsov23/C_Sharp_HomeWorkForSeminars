﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
int i = num / 10000;
int j = num % 10;
int k = num / 1000 % 10;
int n = num / 10 % 10;
if (num > 9999 && num < 100000)
{
    if (i == j && k == n)
    {
        Console.WriteLine("Ура! Это число палиндром! :)");
    }
    else
    {
        Console.WriteLine("К сожалению, это число не палиндром... :(");
    }
}
else
{
    Console.WriteLine("Вы, видимо, ошиблись, это не пятизначное число. Пожалуйста, введите пятизначное число.");
}

