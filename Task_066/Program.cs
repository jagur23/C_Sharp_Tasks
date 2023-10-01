/*
    Задача 66: Задайте значения M и N. Напишите программу, которая 
    найдёт сумму натуральных элементов в промежутке от M до N.
    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30
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

int CountNumbers(int M, int N)
{
    if (M == N)
    {
    return M;
    }
    int sum = M + CountNumbers(M + 1, N);
    return sum;
}

bool IsPositiveNum(int num1, int num2)
{
    if(num1 < 1 || num2 < 1) 
    {
        throw new Exception("Wrong numbers! Try again");
        return false;
    }
    else return true;
}

bool IsSecondNumBigger(int smallNum, int bigNum)
{
    if(smallNum >= bigNum)
    {
        throw new Exception("First number must be smaller then second! Try again");
        return false;
    }
    return true;
}

int M = GetNumber("Enter the smaller natural number: ");
int N = GetNumber("Enter the bigger natural number: ");
IsPositiveNum(M, N);
IsSecondNumBigger(M, N);
int sum = CountNumbers(M, N);
Console.WriteLine($"M = {M}, N = {N} -> {sum}");