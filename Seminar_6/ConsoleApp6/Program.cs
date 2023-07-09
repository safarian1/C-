//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите числа через пробел:");
int[] array = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i]>0)
    {
        count++;
    }
}

Console.WriteLine($"Количество чисел больше нуля: {count}");



//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите b1:");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите k1:");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите b2:");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите k2:");
double k2 = double.Parse(Console.ReadLine());


double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Точка пересечения двух прямых: {x} {y}");


