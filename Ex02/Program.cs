// Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, и возвращает
// значение этого элемента или же указание, что такого элемента нет.

(int, int) GetSizeByUser()
{
  int row = Convert.ToInt32(Console.ReadLine());
  int columns = Convert.ToInt32(Console.ReadLine());
  return (row, columns);
}

int[,] GenerateMatrix(int rows, int columns)
{
  int[,] arr = new int[rows, columns];

  for (int r = 0; r < rows; r++)
  {
    for (int c = 0; c < columns; c++)
    {
      arr[r, c] = Convert.ToInt32(new Random().Next(0, 100));
    }
  }
  return arr;
}

int FindElement(int[,] matr, int row, int column)
{
  if (row >= matr.GetLength(0) || row < 0 || column >= matr.GetLength(1) || column < 0)
  {
    Console.WriteLine("Element not found!");
    return -1;
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
Console.WriteLine("Введите размер массива: ");
(int row, int columns) size = GetSizeByUser();
int[,] matrix = GenerateMatrix(size.row, size.columns);
Print2DArray(matrix);
Console.WriteLine("Введите индексы искомого элемента: ");
(int row, int columns) findEl = GetSizeByUser();
Console.WriteLine(FindElement(matrix, findEl.row, findEl.columns));
