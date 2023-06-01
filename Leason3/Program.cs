// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = 5;
int n = 5;
int[,] array = GetArray(m, n);
Console.WriteLine("Массив: ");
PrintArray(array);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
CrArrNumArray(array);

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

int[,] CrArrNumArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        double sum  = 0;
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i,j];
        }
        Console.Write($"{sum / arr.GetLength(1)} ");
    }
    return arr;
}