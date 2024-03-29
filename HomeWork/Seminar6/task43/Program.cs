﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Описание решения:
//x в уравнениях y = k1 * x + b1; y = k2 * x + b2 будем искать системой уравнений: 
//y-y=k1*x+b1-(k2*x+b2) = k1*x-k2*x-(-b1+b2) = (k1-k2)*x-(-b1+b2);
//(k1-k2)*x-(-b1+b2)=0; 
//(k1-k2)*x=(-b1+b2); 
//x=(-b1+b2)/(k1-k2);

double ReadInput(string numName)// Метод предлагает ввести значения, конвертирует в вещественные и принимает их
{
    Console.Write($"Введите заначение {numName}: ");
    return Convert.ToDouble(Console.ReadLine());
}
void GetDotCross(double q1, double z1, double q2, double z2) // Метод находит Х и выводит координаты точки пересечения.
{
    double x = (-q1+q2)/(z1-z2);
    double y = z1*x+q1;
    Console.Write($"Точка пересечения прямых имеет координаты:({x}; {y})");
}

double b1 = ReadInput("b1");
double k1 = ReadInput("k1");
double b2 = ReadInput("b2");
double k2 = ReadInput("k2");
GetDotCross(b1, k1, b2, k2);
 

