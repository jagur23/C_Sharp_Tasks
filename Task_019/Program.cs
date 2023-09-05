/*
    Задача 19: Напишите программу, которая принимает на 
    вход пятизначное число и проверяет, является ли оно 
    палиндромом.
*/

Console.Write("Enter 5-digit number >>> ");
int number = Convert.ToInt32(Console.ReadLine());


if(number > 9999 && number < 100000)
{
    if(number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10)
    {
        Console.WriteLine("This number is polyndrome!");
    }
    else
    {
        Console.WriteLine("This number is not a polyndrome!");
    }
}
else
{
    Console.WriteLine("This is not a 5-digit number! Try again.");
}