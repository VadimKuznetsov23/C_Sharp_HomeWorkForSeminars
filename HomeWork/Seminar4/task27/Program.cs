// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int nums = ReadInt("Введите любое число: ");
Console.Write($"Сумма всех цифр введенного числа равна: {GetSum(nums)}");

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int GetSum(int num)
{
    int sum = 0;
    int n = 0;
    while (num > 0)
    {
        n = num%10;
        num = num/10;
        sum = sum+n;
    }
return sum;
}