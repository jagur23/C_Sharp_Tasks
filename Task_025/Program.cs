/*
    Задача 25: Напишите цикл, который принимает на вход 
    два числа (A и B) и возводит число A в натуральную 
    степень B.
    3, 5 -> 243 (3⁵)
    2, 4 -> 16
*/


Console.Clear();

/*
double Exponentiation(int A, int B)
{
    double result = Math.Pow(A, B);
    Console.Write($"{A}, {B} -> {result}");
    return result;
}

double num = Exponentiation(3, 5);
*/

int Request(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine()!);
    return num;
}

double Exponentiation(int A, int B)
{
    double result = Math.Pow(A, B);
    return result;
}

bool ValidateExponent(int exponent)
{
    if(exponent < 0)
    {
        Console.Write("Exponent must be natural number. Try again!");
        return false;
    }
    else 
    return true;
}

int powerBase = Request("Enter power base: ");
int exponent = Request("Enter exponent: ");

if(ValidateExponent(exponent))
{
    Console.WriteLine($"Number {powerBase} to the power of {exponent} equel {Exponentiation(powerBase, exponent)}.");
}