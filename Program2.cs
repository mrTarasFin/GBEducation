/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.*/

/*int ShowSecondNum(int number)
{
    int num = (number / 10) % 10;
    return num;
}
Console.WriteLine(ShowSecondNum(189));
*/

/*Задача 13: Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.*/

/*void ShowThirdNum(int number)
{
    int num = number / 100 == 0 ? -1 : number % 10;
    if (num == -1) 
    Console.WriteLine($"Number {number} consists of two numbers");
    else
    Console.WriteLine($"Third number is {number}");
} 

ShowThirdNum(13);*/


/*Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.*/

void ShowWhichDay(int number)
{
   if (number == 6 ||number == 7) Console.WriteLine($"Day is hollyday");
   else Console.WriteLine($"Day is working day");
}

ShowWhichDay(7);