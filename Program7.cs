/*Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.*/

/*void FeelArray(int m, int n)
{
  double[,] arr = new double[m, n];
  Random rand = new Random();
  for (int eli = 0; eli < m; eli++)
  {
    for (int elj = 0; elj < n; elj++)
    {
      arr[eli,elj] = rand.NextDouble()*10;
      Console.Write($"{arr[eli, elj]} \t");
    }
    Console.WriteLine();
  }
}

FeelArray(3, 4);*/



/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.*/

/*int[,] FeelArray(int m, int n)
{
  int[,] arr = new int[m, n];
  Random rand = new Random();
  for (int eli = 0; eli < m; eli++)
  {
    for (int elj = 0; elj < n; elj++)
    {
      arr[eli,elj] = rand.Next(10);
      Console.Write($"{arr[eli, elj]} \t");
    }
    Console.WriteLine();
  }
  return arr;
}

void CheckPosition(int[,] arr, int i, int j)
{
  if (i < arr.GetLength(0))
  {
    if (j < arr.GetLength(1)) Console.WriteLine($"Pozition with {i} and {j} is {arr[i, j]}");
    else Console.WriteLine($"Pozition with {i} and {j} is not exists");
  }
}

int[,] arr = FeelArray(3, 4);
CheckPosition(arr, 1, 3);*/

/*Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.*/


/*double[,] FeelArray(int m, int n)
{
  double[,] arr = new double[m, n];
  Random rand = new Random();
  for (int eli = 0; eli < m; eli++)
  {
    for (int elj = 0; elj < n; elj++)
    {
      arr[eli,elj] = rand.Next(10);
      Console.Write($"{arr[eli, elj]} \t");
    }
    Console.WriteLine();
  }
  return arr;
}

void Averarray(double[,] arr)
{
  double[] avearr = new double[arr.GetLength(1)+1];
  for (int eli = 0; eli < arr.GetLength(1); eli++)
  {
    double element = 0;
    int r = 0;
    while (r < arr.GetLength(0))
    {
      element += arr[r, eli];
      r++;
    }
    avearr[eli] = element/arr.GetLength(0);
    //Console.Write($"{avearr[eli]} ");
    Console.Write(string.Format("{0:F2} ", avearr[eli]));
  }
}

Averarray(FeelArray(3, 4));*/
