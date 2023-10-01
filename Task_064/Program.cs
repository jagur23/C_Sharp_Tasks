/*
    Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
    числа в промежутке от N до 1. Выполнить с помощью рекурсии.
    N = 5 -> "5, 4, 3, 2, 1"
    N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Clear();

int GetNumber(string message)
{
    Console.Write($"{message}");
    string strNum = Console.ReadLine();
    int num = 0;

    if (int.TryParse(strNum, out num))
    {
        return num;
    }
    Console.WriteLine("Wrong format!");
    return GetNumber(message);
}

string PrintNumbers(int start, int stop)
{
    if (start == stop)
    {
    return Convert.ToString(start);
    }
    string str = Convert.ToString(start) + ", " + PrintNumbers(start - 1, stop);
    return str;
}

bool IsPositiveNum(int num)
{
    if(num < 1) 
    {
        throw new Exception("Wrong number! Try again");
        return false;
    }
    else return true;
}

int start = GetNumber("Введите число N: ");
int stop = 1;
IsPositiveNum(start);
Console.WriteLine($"N = {start} -> {PrintNumbers(start, stop)}");