// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите размер массива:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arraySquare = new int[n, n];

int number = 1;
int i = 0;
int j = 0;

while (number <= arraySquare.GetLength(0) * arraySquare.GetLength(1))
{
  arraySquare[i, j] = number;
  number++;
  
  if (i <= j + 1 && i + j < arraySquare.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= arraySquare.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > arraySquare.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(arraySquare);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($" {array[i,j]} ");

    }
    Console.WriteLine();
  }
}