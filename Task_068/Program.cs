/*
    Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
    Даны два неотрицательных числа m и n.
    m = 2, n = 3 -> A(m,n) = 9
    m = 3, n = 2 -> A(m,n) = 29
*/

Console.Clear();

int Akk(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
        if ((n != 0) && (m == 0))
            return Akk(n - 1, 1);
        else
            return Akk(n - 1, Akk(n, m - 1));
}

int GetNumber(string message)
{
    Console.WriteLine($"{message}");
    string strNum = Console.ReadLine();
    int num = 0;

    if (int.TryParse(strNum, out num))
    {
        return num;
    }
    Console.WriteLine("Wrong format!");
    return GetNumber(message);
}

bool IsPositive(int num1, int num2)
{
    if(num1 < 0 || num2 < 0) 
    {
        throw new Exception("Wrong numbers! Try again");
        return false;
    }
    else return true;
}

int n = GetNumber("Enter first natural number: ");
int m = GetNumber("Enter second natural number: ");
IsPositive(n, m);
int akkNum = Akk(n, m);
Console.WriteLine(akkNum);