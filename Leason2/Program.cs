// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет

Console.Write("Введите строку массива: ");
int rows = int.Parse(Console.ReadLine()!) - 1;
Console.Write("Введите столбец массива: ");
int colums = int.Parse(Console.ReadLine()!) - 1;
int m = 5;
int n = 5;
int[,] array = GetArray(m, n);
Console.WriteLine("Массив: ");
PrintArray(array);
CheckNumArray(array);

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(0, 9);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ") ;
        }
        Console.WriteLine();
    }
}

void CheckNumArray(int[,] arr)
{
    if (rows < 0 | rows > arr.GetLength(0) - 1 | colums < 0 | colums > arr.GetLength(1) - 1)
{
Console.WriteLine("Такого числа в массиве нет  ");
}
    else
{
    Console.WriteLine($"Значение элемента в массиве = {arr[rows, colums]}");
}
}
