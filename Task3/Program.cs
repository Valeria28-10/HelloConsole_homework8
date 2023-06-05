// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
Console.Write("Введите количество строк 1-й матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 1-й матрицы и строк 2-й матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 2-й матрицы: ");
int l = Convert.ToInt32(Console.ReadLine());

int[,] firstArray = new int[m, n];
FillArray(firstArray);

int[,] secondArray = new int[n, l];
FillArray(secondArray);

int[,] productArray = new int[m, l];
{
  for (int i = 0; i < firstArray.GetLength(0); i++)
  {
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
      for (int k = 0; k < secondArray.GetLength(0); k++)
      {
        productArray[i,j] += firstArray[i,k] * secondArray[k,j];
      }
    }
  }
}
Console.WriteLine("1-я матрица:");
PrintArray(firstArray);
Console.WriteLine();
Console.WriteLine("2-я матрица:");
PrintArray(secondArray);
Console.WriteLine();
Console.WriteLine("Произведение двух матриц:");
PrintArray(productArray);
