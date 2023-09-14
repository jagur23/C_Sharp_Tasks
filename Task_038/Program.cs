/*
    Задача 38: Задайте массив вещественных чисел. 
    Найдите разницу между максимальным и минимальным элементов массива.
    [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

Console.Clear();

double[] GetArray(int size, int min, int max)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.Next(min, max) + rand.NextDouble(), 2);
    }
    return array;
}

double MaxSubtractMin(double[] arr)
{
    double sub = 0;
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max)
        {
            max = arr[i];
        }

        if(arr[i] < min)
        {
            min = arr[i];
        }
    }
    sub = Math.Round(max - min, 2);
    Console.Write($"{max} - {min} = {sub}");
    return sub;
}

double[] myArray = GetArray(5, 1, 100);
Console.Write("[" + string.Join(' ', myArray) + "] => ");
double subtract = MaxSubtractMin(myArray);