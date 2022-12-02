//Напишите программу, которая на вход принимает два числа и выдает, какое число большее,
//а какое меньшее.

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
if(num1>num2)
{Console.WriteLine("Первое число больше второго");}
else if (num2>num1) {Console.WriteLine("Второе число больше первого");}
else {Console.WriteLine("Числа равны");}