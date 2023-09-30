/*
    Задача 60. ...Сформируйте трёхмерный массив . Напишите программу, которая 
    будет построчно выводить массив, добавляя индексы каждого элемента.
    Массив размером 2 x 2 x 2
    66(0,0,0) 25(0,1,0)
    34(1,0,0) 41(1,1,0)
    27(0,0,1) 90(0,1,1)
    26(1,0,1) 55(1,1,1)
*/

Console.Clear();

int GetMatrixSize()
{
    int size = int.Parse(Console.ReadLine()!);
    if(size < 1)  throw new Exception("Wrong number. Try again!");
    return size;
}

int GetMinMaxValue()
{
    int value = int.Parse(Console.ReadLine()!);
    return value;
}

int[,,] Get3DMatrix(int z, int y, int x, int min, int max)
{
    int[,,] matrix3D = new int[z, y, x];
    Random rand = new Random();

    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                matrix3D[i, j, k] = rand.Next(min, max + 1);
            }
        }
    }
    return matrix3D;
}

void PrintMatrix3D(int[,,] matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                Console.Write($"  {matrix3D[i, j, k]} ({j},{k},{i})");
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Enter the value in Z of the 3D matrix: ");
int z = GetMatrixSize();
Console.Write("Enter the value in Y of the 3D matrix: ");
int y = GetMatrixSize();
Console.Write("Enter the value in X of the 3D matrix: ");
int x = GetMatrixSize();
Console.Write("Enter minimal value for random 3D matrix: ");
int minValue = GetMinMaxValue();
Console.Write("Enter maximal value for random 3D matrix: ");
int maxValue = GetMinMaxValue();
int[,,] matrix3D = Get3DMatrix(z, y, x, minValue, maxValue);
Console.Clear();
PrintMatrix3D(matrix3D);