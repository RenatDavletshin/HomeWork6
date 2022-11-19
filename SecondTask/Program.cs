// Напишите программу, которая найдет точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
// задаются пользователем.

Console.WriteLine("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double axisX = (b2 - b1) / (k1 - k2);
double axisY = k2 * axisX + b2;

Console.WriteLine($"Точка пересечения двух прямых: {axisX},{axisY}");

double ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}