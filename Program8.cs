/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
по убыванию элементы каждой строки двумерного массива.*/
/*
int [,] FellArray()
{
  Console.WriteLine("Enter amount row: ");
  int row = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Enter amount column: ");
  int column = Convert.ToInt32(Console.ReadLine());
  Random rand = new Random();
  int[,] arr = new int[row, column];
  for (int elmRow = 0; elmRow < row; elmRow++)
  {
    for (int elmColumn = 0; elmColumn < column; elmColumn++)
    {
      arr[elmRow, elmColumn] = rand.Next(10);
      Console.Write($"{arr[elmRow, elmColumn]} \t");
    }
    Console.WriteLine();
  }
  return arr;
}

int[,] SortRow(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(1); i++)
  {
    for (int j = 1; j < arr.GetLength(0); j++)
    {
      if(arr[i, j-1] > arr[i, j])
      {
        int temp = arr[i, j];
        arr[i, j] = arr[i, j-1];
        arr[i, j-1] = temp;
        j=0;
      }
    }
  }
  return arr;
}

void ShowArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(1); i++)
  {
    for (int j = 0; j < arr.GetLength(0); j++)
    {
      Console.Write($"{arr[i, j]} \t");
    }
  Console.WriteLine();
  }
}

int[,] arr = FellArray();
Console.WriteLine("------------------------");
ShowArray(SortRow(arr));
*/


/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.*/

/*
int[,] FellArray()
{
  bool flag = true;
  int[,] arr = new int[,]{};
  while (flag)
  {
    Console.WriteLine("Enter amount row: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter amount column: ");
    int column = Convert.ToInt32(Console.ReadLine());
    arr = new int[row, column];
    if (column != row)
    {
      Random rand = new Random();
      for (int elmRow = 0; elmRow < row; elmRow++)
      {
        for (int elmColumn = 0; elmColumn < column; elmColumn++)
        {
          arr[elmRow, elmColumn] = rand.Next(10);
          Console.Write($"{arr[elmRow, elmColumn]} \t");
        }
      Console.WriteLine();
      }
      flag = false;
    }
    else{
    Console.Write($"Enter again");
    flag = true;
    }
  }
  return arr;
}


int FindRowMinSum(int[,] arr)
{
  int[] rowSum = new int[arr.GetLength(0)];
  int sum = 0;
  for (int i = 0; i <= arr.GetLength(1); i++)
  {
    for (int j = 0; j < arr.GetLength(0)-1; j++)
    {
      sum += arr[i, j];
    }
    rowSum[i] = sum;
    sum = 0;
  }
  return Array.IndexOf(rowSum, rowSum.Min());
}

Console.WriteLine($"Minimum amount in line {FindRowMinSum(FellArray())}");
*/


/*Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.*/

/*int[,] FellArray()
{
  Console.WriteLine("Enter amount row: ");
  int row = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Enter amount column: ");
  int column = Convert.ToInt32(Console.ReadLine());
  Random rand = new Random();
  int[,] arr = new int[row, column];
  for (int elmRow = 0; elmRow < row; elmRow++)
  {
    for (int elmColumn = 0; elmColumn < column; elmColumn++)
    {
      arr[elmRow, elmColumn] = rand.Next(10);
      Console.Write($"{arr[elmRow, elmColumn]} \t");
    }
    Console.WriteLine();
  }
  return arr;
}

int[,] CompositionTwoArray()
{
  int[,] arr1 = FellArray();
  int[,] arr2 = FellArray();
  if (arr1.GetLength(1) != arr2.GetLength(0)) Console.Write("Матрицы нельзя перемножить");
  int[,] newarr = new int[arr1.GetLength(0), arr2.GetLength(1)];
  for (int i = 0; i < arr1.GetLength(0); i++)
  {
    for (int j = 0; j < arr2.GetLength(1); j++)
    {
      for (int k = 0; k < arr1.GetLength(1); k++)
      {
        newarr[i,j] += arr1[i,k] * arr2[k,j];
      }
    }
  }
  return newarr;
}


void ShowArray(int[,] arr)
{
  Console.WriteLine("------------");
  for (int i = 0; i < arr.GetLength(1); i++)
  {
    for (int j = 0; j < arr.GetLength(0); j++)
    {
      Console.Write($"{arr[i, j]} \t");
    }
  Console.WriteLine();
  }
}
ShowArray(CompositionTwoArray());*/


/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.*/

/*int[,] SpiralArray()
{
  Console.WriteLine("Enter amount row and column: ");
  int sizeArray = Convert.ToInt32(Console.ReadLine());
  int[,] arr = new int[sizeArray, sizeArray];
  int c= 1;
  int cv = 0;
  int iter = 0;
  while (c < sizeArray*sizeArray)
  {
    for (int i = 0; i < sizeArray-iter; i++)
    {
      arr[0,i] = c++;
    }
    iter++;
    for (int j = 1; j < sizeArray - iter; j++)
    {
      arr[j, sizeArray-iter] = c++;
    }
    for (int k = sizeArray-iter; k > cv; k--)
    {
      arr[sizeArray-iter, k] = c++;
    }
    for (int l = sizeArray-iter; l < sizeArray-iter; l--)
    {
      arr[l, cv] = c++;
    }
    cv++;
  }
  return arr;
}

void ShowArray(int[,] arr)
{
  Console.WriteLine("------------");
  for (int i = 0; i < arr.GetLength(1); i++)
  {
    for (int j = 0; j < arr.GetLength(0); j++)
    {
      Console.Write($"{arr[i, j]} \t");
    }
  Console.WriteLine();
  }
}
ShowArray(SpiralArray());
*/
