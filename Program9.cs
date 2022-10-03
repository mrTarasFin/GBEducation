/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет
все натуральные числа в промежутке от M до N.*/

/*
void PrintNumber(int n)
{
  int m = 1;
  if(n != m) PrintNumber(n - 1);
  Console.WriteLine(n);
}

PrintNumber(5);
*/

/*Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.*/


int SumNum(int m, int n)
{
  int sum = 0;
  sum = (n*(n+1))/2-((m-1)*(m-1)+1)/2;
  return sum;
}

Console.WriteLine(SumNum(1, 15));

