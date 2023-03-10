// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


//1.set size of matrix
(int, int) GetSizeByUser()
{
  Console.WriteLine("Введите размер массива: ");
  int row = Convert.ToInt32(Console.ReadLine());
  int column = Convert.ToInt32(Console.ReadLine());
  return (row, column);
}


//2.creat matrix and fill it
int[,] GenerateMatrix(int row, int column)
{
  int[,] arr = new int[row, column];

  for (int r = 0; r < row; r++)
  {
    for (int c = 0; c < column; c++)
    {
      arr[r, c] = Convert.ToInt32(new Random().Next(0, 20));
      Console.Write(arr[r, c] + " ");
    }
    Console.WriteLine();
  }
  return arr;
}
//3. find averenge
string Averange(int[,] matr)
{
  String rez = "";

  for (int c = 0; c < matr.GetLength(1); c++)
  {
    int sum = 0;
    for (int r = 0; r < matr.GetLength(0); r++)
    {
      sum += matr[r, c];
    }
    rez += $"{sum / matr.GetLength(0)}; ";
  }
  return rez;
}

(int row, int column) size = GetSizeByUser();
int[,] matrix = GenerateMatrix(size.row, size.column);
string rez = Averange(matrix);
Console.WriteLine("Cреднее арифметическое каждого столбца: ");
Console.WriteLine(rez);