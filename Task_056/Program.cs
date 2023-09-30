/*
    Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
    которая будет находить строку с наименьшей суммой элементов.

    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7

    Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();

int GetMatrixSize()
{
    int qty = int.Parse(Console.ReadLine()!);
    if(qty < 1)  throw new Exception("Wrong number. Try again!");
    return qty;
}

int GetMinMaxValue()
{
    int value = int.Parse(Console.ReadLine()!);
    return value;
}

int[,] GetMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

bool IsRectangularMatrix(int rows, int column)
{
    if(rows == column)
    {
        throw new Exception("Matrix is not rectangular. Try again.");
        return false;
    }
    else return true;
}

int[] GetRowSumArray(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    int sum = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[i] = sum;
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write(string.Join(' ', array));
}

int GetMinSum(int[] array)
{
    int minSum = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < minSum)
        minSum = array[i];
    }
    return minSum;
}

void FindRowsWithMinSum(int[] array, int min)
{
    Console.Write($"The row with the smallest sum of elements is: ");

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == min)
        Console.Write($"{i + 1}   ");
    }
}

Console.Write("Enter the number of rows: ");
int rows = GetMatrixSize();
Console.Write("Enter the number of columns: ");
int columns = GetMatrixSize();
IsRectangularMatrix(rows, columns);
Console.Write("Enter minimal value for random matrix: ");
int minValue = GetMinMaxValue();
Console.Write("Enter maximal value for random matrix: ");
int maxValue = GetMinMaxValue();
int[,] matrix = GetMatrix(rows, columns, minValue, maxValue);
Console.Clear();
PrintMatrix(matrix);
Console.WriteLine();
int[] arrayOfRowSums = GetRowSumArray(matrix);
//PrintArray(arrayOfRowSums);
Console.WriteLine();
int minSum = GetMinSum(arrayOfRowSums);
//Console.WriteLine($"{minSum}");
FindRowsWithMinSum(arrayOfRowSums, minSum);