﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Для вывода таблицы кубов чисел от 1 до введенного числа, введите число: ");
int n = Convert.ToInt16(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
   double res = Math.Pow(i, 3); 
   if(i < n)
   {
      Console.Write($" {res},");
   }
   else Console.Write($" {res}.");
}
