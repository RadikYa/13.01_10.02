// Задача 43: Напишите программу, которая 
// найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("введите координаты первой прямой ");
Console.Write("b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("введите координаты второй прямой ");
Console.Write("b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());


double distanceX = DistanceX(k1,k2);
double distanceY = DistanceY(b1,b2);
double distanceRoundX = Math.Round(distanceX, 2, MidpointRounding.ToZero);
double distanceRoundY = Math.Round(distanceY, 2, MidpointRounding.ToZero);

Console.WriteLine($"({distanceRoundX}; {distanceRoundY})");


double DistanceX(double x, double y)
{
    x = Convert.ToDouble(b2 - b1) / (k1 - k2);
    return y = k1 * x + b1;
}

double DistanceY(double y, double x)
{
    // return y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
    x = Convert.ToDouble(b2 - b1) / (k1 - k2);
    return y = k2 * x + b2;
}