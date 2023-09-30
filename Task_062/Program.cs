/*
    Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
    Например, на выходе получается вот такой массив:
    1 2 3 4
    12 13 14 5
    11 16 15 6
    10 9 8 7
*/

Console.Clear();

int[,] FillArraySpiral(int[,] array, int rows, int columns)
{
    int counter = 1, i = 0, j = 0;
    while (counter <= rows * columns)
    {
        array[i, j] = counter;
        counter++;
        if (i <= j + 1 && i + j < columns - 1)
        {
            j++;
        }
        else if (i < j && i + j >= rows - 1)
        {
            i++;
        }
        else if (i >= j && i + j > columns - 1)
        {
            j--;
        }
        else
        {
            i--;
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int rowNumber = 4;
int columnNumber = 4;
int[,] spiralArray = new int[rowNumber, columnNumber];
FillArraySpiral(spiralArray, rowNumber, columnNumber);
Console.WriteLine("Spiral array:");
Console.WriteLine();
PrintArray(spiralArray);