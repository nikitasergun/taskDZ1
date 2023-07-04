//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//Пример
//456 -> 5
//782 -> 8
//918 -> 1
int getSecondNumber(int num)
{
    int number = System.Math.Abs(num / 10 % 10);
    return number;
}
Console.WriteLine(getSecondNumber(456));
Console.WriteLine("----------------------");
Console.WriteLine(getSecondNumber(782));
Console.WriteLine("----------------------");
Console.WriteLine(getSecondNumber(918));
Console.WriteLine("----------------------");
