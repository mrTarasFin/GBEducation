/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

/*
int[] CreateArray(int size)
{
    int[] newArray = new int[size];
    
    for(int element = 0; element < size; element++)
    {
        newArray[element] = new Random().Next(100, 999);
    }
    
    return newArray;
} 

void CountEvenNum(int[] array)
{
    int count = 0;
    for(int num = 0; num < array.Length; num++)
    {
        int? res = array[num]%2 == 0 ? count++ : null;
    }
    Console.Write($"In an array {count} of even numbers");
}

CountEvenNum(CreateArray(5));
*/


/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.*/

/*
int[] CreateArray(int size)
{
    int[] newArray = new int[size];
    
    for(int element = 0; element < size; element++)
    {
        newArray[element] = new Random().Next(100);
    }
    
    return newArray;
}

void CountSumEvenNum(int[] array)
{
    int sumnum = 0;
    for(int num = 0; num < array.Length; num++)
    {
        int? res = num%2 == 0 ? sumnum += array[num] : null;
    }
    Console.Write($"In an array of sum even numbers is {sumnum}");
}

CountSumEvenNum(CreateArray(5));
*/


/*Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.*/

/*
double[] CreateArray(int size)
{
    double[] newArray = new double[size];
    
    for(int element = 0; element < size; element++)
    {
        newArray[element] = new Random().NextDouble();
    }
    
    return newArray;
}

void DefBetwNum(double[] array)
{
    double max = array[0];
    double min = array[0];

    for(int el = 1; el < array.Length; el++)
    {
        if (array[el] > max) max = array[el];
        else
        {
            if(array[el] < min) min = array[el];
        }
    }
    Console.WriteLine($"Difference between {max} and {min} is {max-min}");
}

DefBetwNum(CreateArray(5));
*/