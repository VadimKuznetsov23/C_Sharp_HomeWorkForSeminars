﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int NumA = ReadInt("Введите число А: ");
int NumB = ReadInt("Введите число B: ");
TaskSolution(NumA, NumB);

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt16(Console.ReadLine());
}
void TaskSolution(int a, int b)
{
    int res = 1;
    for (int i = 1; i<=b; i++)
    {
    res = res * a;
    }
    Console.WriteLine($"Результат возведения числа {NumA} в степень числа {NumB}, будет равен: " + res);
}