//-Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

var number = Convert.ToInt32(Console.ReadLine());
    var number2 = Convert.ToInt32(Console.ReadLine());
    var number3 = Convert.ToInt32(Console.ReadLine());
                if (number > number2 && number > number3)
                    Console.WriteLine("Nubmer Max = " + number); 
                else if (number2 > number3)
                    Console.WriteLine("Number Max = " + number2); 
                else
                    Console.WriteLine("Number Max = " + number3); 
            
            Console.ReadLine();
