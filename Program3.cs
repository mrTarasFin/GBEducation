/* Задача 19 Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.*/

/*void NumIsPolidrom(int number)
{
    if(number % 10 == number /10000)
    {
        number = (number % 10000) / 10;
        if(number % 10 == number /100) Console.WriteLine("YES");
        else Console.WriteLine("NO"); 
    }
    else Console.WriteLine("NO");
}

NumIsPolidrom(45634);*/

/*Задача 21 Напишите программу, которая принимает на вход
координаты двух точек и находит расстояние между ними в 3D пространстве.*/
/*void CoordLine(float[] arrA, float[] arrB)
{
    double lenLine = 0;
    lenLine = Math.Sqrt(Math.Pow((arrB[0]-arrA[0]),2)+Math.Pow((arrB[1]-arrA[1]),2)+Math.Pow((arrB[2]-arrA[2]),2));
    Console.WriteLine(lenLine);
}

float[] arrAn = new float[]{3, 6, 8};
float[] arrBn = new float[]{2, 1, -7};
CoordLine(arrAn, arrBn);*/

/*Задача 23 Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N*/

/*void tableCub(int number)
{
    for(int el = 1; el < number+1; el++)
    {
        int cub = (int)Math.Pow(el, 3);
        Console.WriteLine($"{cub}");
    }
}

tableCub(3);*/