/*
    Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
    по убыванию элементы каждой строки двумерного массива.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    В итоге получается вот такой массив:
    7 4 2 1
    9 5 3 2
    8 4 4 2
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

void RowSorting(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(1)];
    int temp = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[j] = matrix[i, j];
        }

        for (int l = 0; l < array.Length; l++)
        {
          for (int k = 0; k < array.Length - 1; k++)
          {
            if(array[k] == array[k + 1]) continue;

            if(array[k] < array[k + 1])
            {
                temp = array[k + 1];
                array[k + 1] = array[k];
                array[k] = temp;
            }
          }
        }
        Console.Write(string.Join('\t', array));
        Console.WriteLine();
    }
}

Console.Write("Enter the number of rows: ");
int rows = GetMatrixSize();
Console.Write("Enter the number of columns: ");
int columns = GetMatrixSize();
Console.Write("Enter minimal value for random matrix: ");
int minValue = GetMinMaxValue();
Console.Write("Enter maximal value for random matrix: ");
int maxValue = GetMinMaxValue();
int[,] matrix = GetMatrix(rows, columns, minValue, maxValue);
Console.Clear();
PrintMatrix(matrix);
Console.WriteLine();
RowSorting(matrix);