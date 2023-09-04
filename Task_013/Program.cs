/*
    Задача 13: Напишите программу, которая выводит 
    третью цифру заданного числа или сообщает, что третьей 
    цифры нет.
*/

Console.WriteLine("Enter a number please: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number > 999)
{
    number /= 10;
    number = number % 10;
    Console.WriteLine("Third digit is: " + number);
}

if (number > 99 && number < 1000)
{
    Console.WriteLine("Third digit is: " + number % 10);
}
else
{
    Console.WriteLine("Third digit does not exist!");
}

