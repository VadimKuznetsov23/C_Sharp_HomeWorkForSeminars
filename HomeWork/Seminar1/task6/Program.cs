﻿//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.

Console.WriteLine("Для проведения проверки числа на четность (обычно мы не задаем лишних вопросов), и все же любопытно, зачем Вам это тяжелое знание, но если Вы настаиваете, то введите любое число и нажмите Enter");
int num = int.Parse(Console.ReadLine()!);
if (num % 2 == 0)
{
    Console.WriteLine("Не знаем, хорошо это или плохо, но это число чётное.");
}
else
{ Console.WriteLine("Не знаем, хорошо это или плохо, но это число не чётное."); 
}