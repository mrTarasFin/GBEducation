/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.*/

/*int FindDegree(int a, int b)
{
    int deg = 1;
    for(int el = 1; el < b + 1; el++) 
    {
        deg *= a;
    }
    return deg;
}

Console.Write("Input number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write($"Number {a} of the power {b} is {FindDegree(a, b)}");*/


/*Задача 27: Напишите программу, которая принимает  
на вход число и выдаёт сумму цифр в числе.*/

/*int SumNum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num%10;
        num /= 10; 
    }
    return sum;
}

Console.Write("Input number A: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"Sum numbers of {num} is {SumNum(num)}");*/


/*Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.*/

/*void WriteArray()
{
    int[] arr = new int[8];
    for(int el = 0; el < 8; el++)arr[el] = new Random().Next(0, 9);

    for(int elArr = 0; elArr < arr.Length; elArr++)Console.Write($"{arr[elArr]} ");
}

WriteArray();*/