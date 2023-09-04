/*
Задача 10: Напишите программу, которая принимает на 
вход трёхзначное число и на выходе показывает вторую 
цифру этого числа.
*/

Console.WriteLine("Enter a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
    Console.WriteLine(num % 100 / 10);
}
else
{
    Console.WriteLine("Not a three-digit number!");
}