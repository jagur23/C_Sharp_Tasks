/*
    Задача 43. Напишите программу, которая найдёт точку 
    пересечения двух прямых, заданных уравнениями y = k1 * x + 
    b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются 
    пользователем.
    b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();

double GetNum(string variable)
{
    Console.Write($"Enter {variable} value: ");
    double num = double.Parse(Console.ReadLine()!);
    return num;
}

void Intersection(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.Write($"The point of intersection of two straight lines is: (x = {x}; y = {y})");
}

Console.WriteLine("Two lines given by equations: y = k1 * x + b1 and y = k2 * x + b2;");
double b1 = GetNum("b1");
double k1 = GetNum("k1");
double b2 = GetNum("b2");
double k2 = GetNum("k2");
Intersection(b1, k1, b2, k2);

