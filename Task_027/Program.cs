/*
    Задача 27: Напишите программу, которая принимает на 
    вход число и выдаёт сумму цифр в числе.
    452 -> 11
    82 -> 10
    9012 -> 12
*/

Console.Clear();

int DigitSum(string number)
{
    int result = 0;

    for(int i = 0; i < number.Length; i++)
    {
        result = result + int.Parse(number[i].ToString());
    }
    return result;
}

Console.Write("Enter natural number: ");
string number = Console.ReadLine()!;
int num = int.Parse(number);

if(num > 0)
{
    int sum = DigitSum(number);
    Console.WriteLine($"{number} -> {sum}");
}
else
{
    Console.WriteLine("Wrong number. Try again :)");
}