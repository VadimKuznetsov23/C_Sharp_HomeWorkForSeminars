// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое число: ");
int num = int.Parse(Console.ReadLine()!);
if(num > 99 && num < 1000)
{
Console.WriteLine(num = num%10);

if(num>999 && num<10000)

    Console.WriteLine(num = num/10%10);
}



