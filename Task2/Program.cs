//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка.

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

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        array[i, j] = new Random().Next(0,10); 
        }
    }
}
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array2d = new int[m, n];

int SummaLineElements(int[,] array)
{
    int [] summaLine = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summaLine[i] += array[i,j];
        }
    }
    Console.WriteLine($"Сумма элементов в каждой строке: {String.Join(',', summaLine)}");
    int minSummaLine = 0;
    int temp = summaLine[0];
    for (int i = 0; i < summaLine.Length; i++)
    {
        if(temp > summaLine[i])
        {
            temp = summaLine[i];
            minSummaLine = i;
        }
    }
    return minSummaLine;
}

FillArray(array2d);
Console.WriteLine();
PrintArray(array2d);
int minIndex = SummaLineElements(array2d);
Console.WriteLine($"Строка {minIndex + 1} имеет наименьшую сумму элементов");