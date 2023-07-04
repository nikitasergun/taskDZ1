//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.WriteLine();
void getThirdNumber(int num)
{
    int number = 0;
    int tmp = num; // только для красивого вывода

    if (num < 100)
        Console.WriteLine($"{num} двухзначное число");
    else
    {
        while (num > 100)
        {
            number = num % 10;
            num = System.Math.Abs(num / 10);
        }
        Console.WriteLine($"Третья цифра числа {tmp} = {number}");
    }
}
getThirdNumber(645);
getThirdNumber(78);
getThirdNumber(32679);
Console.WriteLine("\n----------------------");