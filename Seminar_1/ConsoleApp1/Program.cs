﻿// Напишите программу,которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введи первое целое число: ");

int num1 = int.Parse(Console.ReadLine());


Console.Write("Введи второе целое число: ");

int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}

else
{
    Console.WriteLine($"Число {num1} меньше числа {num2}");
}

