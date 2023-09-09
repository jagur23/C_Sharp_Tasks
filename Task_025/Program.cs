/*
    Задача 25: Напишите цикл, который принимает на вход 
    два числа (A и B) и возводит число A в натуральную 
    степень B.
    3, 5 -> 243 (3⁵)
    2, 4 -> 16
*/

Console.Clear();

double Exponentiation(int A, int B)
{
    double result = Math.Pow(A, B);
    Console.Write($"{A}, {B} -> {result}");
    return result;
}

double num = Exponentiation(3, 5);