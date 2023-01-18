// Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, и возвращает
// значение этого элемента или же указание, что такого элемента нет.

int[,] GenerateMatrix(int rows, int columns)
{
  int[,] arr = new int[rows, columns];


  for (int r = 0; r < rows; r++)
  {
    for (int c = 0; c < columns; c++)
    {
      arr[r, c] = Random.Shared.Next(0, 10);
    }
  }

  return arr;
}

int FindElement(int[,] matr, int row, int column)
{
  if (row >= matr.Length && row < 0 && column >= matr.GetLength(1) || column < 0)
  {
    Console.WriteLine("Element not found!");
  }
  return matr[row, column];
}


void Print2DArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write(matr[i, j] + " ");
    }
    Console.WriteLine();
  }
}

int[,] matrix = GenerateMatrix(5, 5);
Print2DArray(matrix);
Console.WriteLine(FindElement(matrix, 2, 2));