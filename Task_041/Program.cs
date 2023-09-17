/*
    Задача 41: Пользователь вводит с клавиатуры M чисел. 
    Посчитайте, сколько чисел больше 0 ввёл пользователь.
    0, 7, 8, -2, -2 -> 2
    -1, -7, 567, 89, 223-> 3
*/

Console.Clear();

int PositiveNumCount(string numArray)
{
    string[] strArr = numArray.Split(' ');
    int[] intArr = Array.ConvertAll(strArr, int.Parse);
    int count = 0;
    for (int i = 0; i < intArr.Length; i++)
    {
        if(intArr[i] > 0)  count++;
    }
    return count;
}

Console.Write("Type the numbers separated by a space and press Enter: ");
string arrayString = Console.ReadLine()!;
Console.Clear();
int positiveNumCount = PositiveNumCount(arrayString);
Console.Write($"{arrayString} -> {positiveNumCount}");
