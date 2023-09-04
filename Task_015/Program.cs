/*
    Задача 15: Напишите программу, которая принимает на 
    вход цифру, обозначающую день недели, и проверяет, 
    является ли этот день выходным.
*/

Console.Write("Enter digit from 1 to 7 > ");
int weekDay = Convert.ToInt32(Console.ReadLine());

if(weekDay > 0 && weekDay < 8)
{
    if(weekDay == 6 || weekDay == 7)
    {
        Console.WriteLine("Today is a day off!!!");
    }
    else
    {
        Console.WriteLine("Go to the work!!!");
    }
}
else 
{
    Console.WriteLine("Wrong digit! Enter digit from 1 to 7");
}