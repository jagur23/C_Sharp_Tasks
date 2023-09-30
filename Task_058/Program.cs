/*
    Задача 58: Задайте две матрицы. Напишите программу, которая будет 
    находить произведение двух матриц.

    Произведение матриц (С= АВ) — операция только для согласованных матриц А и В, 
    у которых число столбцов матрицы А равно числу строк матрицы В.
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
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] GetMatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    int sum = 0;

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }    
    }
    return resultMatrix;
}

bool IsConsistentMatrices(int[,] firstMatrix, int[,] secondMatrix)
{
    if(firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
    {
        throw new Exception("Number of column in first matrix must be equel number of rows in second matrix.");
        return false;
    }
    else return true;
}

Console.Write("Enter the number of rows for first matrix: ");
int rows1 = GetMatrixSize();
Console.Write("Enter the number of columns for first matrix: ");
int columns1 = GetMatrixSize();
Console.Write("Enter the number of rows for second matrix: ");
int rows2 = GetMatrixSize();
Console.Write("Enter the number of columns for second matrix: ");
int columns2 = GetMatrixSize();
Console.Write("Enter minimal value for random matrix: ");
int minValue = GetMinMaxValue();
Console.Write("Enter maximal value for random matrix: ");
int maxValue = GetMinMaxValue();
int[,] matrix1 = GetMatrix(rows1, columns1, minValue, maxValue);
int[,] matrix2 = GetMatrix(rows2, columns2, minValue, maxValue);
IsConsistentMatrices(matrix1, matrix2);
Console.Clear();
Console.WriteLine("Matrix 1 is:");
PrintMatrix(matrix1);
Console.WriteLine();
Console.WriteLine("Matrix 2 is:");
PrintMatrix(matrix2);
Console.WriteLine();
int[,] resultMatrix = GetMatrixMultiplication(matrix1, matrix2);
Console.WriteLine("Result of multiplication: ");
PrintMatrix(resultMatrix);