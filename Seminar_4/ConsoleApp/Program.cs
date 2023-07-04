//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine());
int stepen = a;

for (int i = 1; i < b; i++)
{
stepen = stepen * a;
}
Console.WriteLine($"A в натуральной степени B равно: {stepen}");




 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int i = int.Parse(Console.ReadLine());
int sum = 0;

while (i > 0)
{
int num = i % 10;
i = i / 10;
sum = sum + num;
}
Console.WriteLine($"Сумма цифр в числе равна: {sum} ");




// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] array = new int[8];
Console.Write("[");
for (int i = 0; i < array.Length; i++)
 {
    array [i] = new Random().Next(0, 9);
    Console.Write(array[i] + " ");
 }
Console.Write("]");
