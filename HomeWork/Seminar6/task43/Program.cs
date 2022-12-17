// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double ReadLine(string numName)
{
    Console.Write($"Введите заначение {numName}: ");
    return Convert.ToDouble(Console.ReadLine());
}
void GetDotCross(double z1, double q1, double z2, double q2)
{//x в уравнениях y = k1 * x + b1, y = k2 * x + b2; ищем системой из этих уравнений: 
//y-y=(k1*x+b1)-(k2*x+b2) = (k1-k2)*x-(-b1+b2);
//(k1-k2)*x-(-b1+b2)=0; 
//(k1-k2)*x=(-b1+b2); 
//x=(-b1+b2)/(k1-k2);
    double x = (-z1+z2)/(q1-q2);
    double crosCor1 = q1*x+z1;
    double crosCor2 = q2*x+z2;
    Console.Write($"Точка пересечения прямых имеет координаты:({crosCor1}; {crosCor2})");
}

double b1 = ReadLine("b1");
double k1 = ReadLine("k1");
double b2 = ReadLine("b2");
double k2 = ReadLine("k2");
GetDotCross(b1, k1, b2, k2);
 

