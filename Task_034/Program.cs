/*
    Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
    Напишите программу, которая покажет количество чётных чисел в массиве.
    [345, 897, 568, 234] -> 2
*/

Console.Clear();

int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(min, max);
    }
    return array;
}

int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] myArray = GetArray(10, 100, 1000);
Console.Write("[" + string.Join(' ', myArray) + "] -> ");
int evenNumQty = CountEvenNumbers(myArray);
Console.Write(evenNumQty);