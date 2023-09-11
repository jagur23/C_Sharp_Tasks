/*
    Задача 29: Напишите программу, которая задаёт массив 
    из 8 элементов и выводит их на экран.

    1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
    6, 1, 33 -> [6, 1, 33]
*/

Console.Clear();

/*
int[] array = new int[8];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
}

for(int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}, ");
}

Console.Write("-> [");

foreach(int element in array)
{
    Console.Write(element + ", ");
}

Console.Write("]");
*/

int Request(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine()!);
    return num;
}

int [] GenerateArrey(int length, int min, int max)
{
    int [] arrey = new int[length];

    for(int i = 0; i < length; i++)
    {
        arrey[i] = new Random().Next(min, max + 1);
    }
    return arrey;
}

void PrintArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }

    Console.Write("-> [");

    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }

    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}

int arrLength = Request("Enter arrey length: ");
int min = Request("Enter the value of the minimum random number: ");
int max = Request("Enter the value of the maximum random number: ");

int [] myArray = GenerateArrey(arrLength, min, max);
PrintArray(myArray);