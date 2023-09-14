/*
    Задача 36: Задайте одномерный массив, заполненный случайными числами. 
    Найдите сумму элементов, стоящих на нечётных позициях.
    [3, 7, 23, 12] -> 19
    [-4, -6, 89, 6] -> 0
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

int OddIndexValueCount(int[] array)
{
    int sum = 0;
    int i = 1;

    for ( ; i < array.Length; )
    {
        sum = sum + array[i];
        i += 2;
    }
    return sum;
}

int[] myArray = GetArray(10, -100, 100);
Console.Write("[" + string.Join(' ', myArray) + "] -> ");
int oddIndexSum = OddIndexValueCount(myArray);
Console.Write(oddIndexSum);