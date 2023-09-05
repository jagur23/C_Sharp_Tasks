/*
    Задача 23: Напишите программу, которая принимает на 
    вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    3 -> 1, 4, 9. 
    5 -> 1, 8, 27, 64, 125
*/

Console.Write("Enter natural number >>> ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write(N + " -> ");

if(N > 0)
{
    for(int count = 1; count <= N; count++)
    {
        Console.Write(Math.Pow(count, 3) + ", ");
    }
}
else
{
    Console.WriteLine("Not natural number. Try again :)");
}