/*Задача 55:**Задайте двумерный массив.
 Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7*/
using System;
using static System.Console;
Clear();
int [,] array=GetArray(4,5, 0, 10);
PrintArray(array);
WriteLine();
PrintArray(NewArray(array));

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}

int[,] NewArray(int[,]array)
{
    int[,]res = new int [array.GetLength(1), array.GetLength(0)];
    for(int i=0; i < array.GetLength(1);i++)
    {
        for(int j=0; j<array.GetLength(0);j++)
        {
            res[i,j]= array[j,i];
        }
    }
    return res;

}
