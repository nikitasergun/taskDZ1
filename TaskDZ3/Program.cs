// - Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4->да
//- 3->нет
//7->нет

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;                             
            Console.WriteLine("введите число: ");
            a = Convert.ToInt32(Console.ReadLine()); 
 
            if (a % 2 == 0){Console.WriteLine("четное число");}
            else
            {Console.WriteLine("нечетное"); }
 
 
 
            Console.ReadKey();
        }
    }
}