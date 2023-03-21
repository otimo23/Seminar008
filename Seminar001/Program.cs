/*Задача 53 Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.*/


using System;
using static System.Console;
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
int [,] NewArray(int[,]array)
{ 

int temp =0;

    for(int i=0; i<array.GetLength(1);i++)
    {
        temp = array[0,i];
        array[0,i] = array[array.GetLength(0)-1,i];
        array[array.GetLength(0)-1,i] = temp;

    }
    return array;
    
}
/*Меняет любые строки, заданные пользователем в массиве.
Write("Введите строку 1: ");
int a1 = int.Parse(ReadLine());
Write("Введите строку 2: ");
int b1 = int.Parse(ReadLine());
ChangeRows(array, a1, b1);
PrintArray(array);
void ChangeRows(int[,] inArray, int a, int b)
{
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        int k = inArray[a - 1, i];
        inArray[a - 1, i] = inArray[b - 1, i];
        inArray[b - 1, i] = k;
    }
}*/