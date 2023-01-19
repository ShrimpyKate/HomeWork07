// Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

//1.задать размер массива
//2.создать массив
//2.наполнить массив
//3.напечатать массив
//

(int, int) GetSizeByUser()
{
  Console.WriteLine("Введите размер массива: ");
  int row = int.Parse(Console.ReadLine());
  int columns = int.Parse(Console.ReadLine());
  return (row, columns);
}

double[,] CreateMatrix(int row, int columns)
{
  double[,] matr = new double[row, columns];
  return matr;
}

void FillandPrintMatrix(double[,] matr)
{
  Random rand = new Random();
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      matr[i, j] = Convert.ToDouble(rand.Next(-10, 100) / 10.0);
      Console.Write(matr[i, j] + " ");
    }
    Console.WriteLine();
  }
}

(int row, int columns) size = GetSizeByUser();
double[,] matrix = CreateMatrix(size.row, size.columns);
FillandPrintMatrix(matrix);


