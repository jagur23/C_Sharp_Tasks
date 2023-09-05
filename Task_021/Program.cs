/*
    Задача 21: Напишите программу, которая принимает на 
    вход координаты двух точек и находит расстояние 
    между ними в 3D пространстве.
    A (3,6,8); B (2,1,-7), -> 15.84
    A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Write("Enter the coordinates of the first point in X > ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the coordinates of the first point in Y > ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the coordinates of the first point in Z > ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the coordinates of the second point in X > ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the coordinates of the second point in Y > ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the coordinates of the second point in Z > ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));

Console.WriteLine("Distance between two points is: " + Math.Round(distance, 2));