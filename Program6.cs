/*Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

/*int CountNumber(int[] arraynum)
{
    int res = 0;
    for(int el = 0; el < arraynum.Length; el++)
    {
        res = arraynum[el] > 0 ? res +=1: res += 0;
    }

    return res;
}

int[] EnterArrayUser()
{
    int[] arraynum = new int[100];
    int el = 0;
    string num;
    while ((num = Console.ReadLine()) != "stop")
    {
        arraynum[el++] = Convert.ToInt32(num);
    }
    return arraynum;
}

Console.WriteLine("Enter interger numbers in order, to stop enter 'stop'");
Console.WriteLine($"Intergers number more than zero is: {CountNumber(EnterArrayUser())}");
*/

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.*/

/*void PointIntersection(double k1, double b1, double k2, double b2)
{
  double x = (b2-b1)/(k1-k2);
  double y = k1*(b2-b1)/(k1-k2) + b1;

  Console.Write($"{x}, {y}");

}

PointIntersection(5, 2, 9, 4);*/
