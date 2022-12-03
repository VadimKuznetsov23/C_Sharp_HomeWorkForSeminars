//Напишите программу, которая на вход принимает три числа и выдаёт максимальное из этих чисел.

int Max(int num1, int num2, int num3)
{
    int result = num1;
    if(num2 > result) result = num2;
    if(num3 > result) result = num3;
    return result;
}
Console.WriteLine("Для определения максимального числа из трех предложенных Вами, пожалуйста, введите первое число и нажмите клавишу Enter ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Теперь введите второе число и снова нажмите клавишу Enter ");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("И, наконец, введите третье число после чего отодвиньтесь от экрана подальше... (шутка), просто снова Enter ");
int num3 = int.Parse(Console.ReadLine()!);
int max = Max(num1, num2, num3);
Console.WriteLine($"Путем наисложнейших вычислений (наши ученые не спали трое суток) мы пришли к выводу, что максимальное введенное Вами число: {max}");
Console.Write("Для повторения этого небезопасного эксперимента перезапустите программу, и да пребудет с Вами сила))");