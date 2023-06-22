/*
// Напишите программу,которая на вход принимает два числа и выдаёт,
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

*/

//Напишите программу, которая принимает на вход 
//три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введи первое  число: ");

int num1 = int.Parse(Console.ReadLine());


Console.Write("Введи второе число: ");

int num2 = int.Parse(Console.ReadLine());


Console.Write("Введи третье число: ");

int num3 = int.Parse(Console.ReadLine());


int max = num1;

if (num2 > max) 
{
    max = num2;
}

if (num3 > max)
{
    max = num3;
}

Console.WriteLine($"Максимальное число: {max} ");