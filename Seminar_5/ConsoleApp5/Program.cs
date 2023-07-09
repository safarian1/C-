

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] array = new double[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round((new Random().NextDouble() * new Random().Next(0,10)), 2);
    Console.Write(array[i] + "  ");
}

double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}

Console.WriteLine($"Максимальное значение: {max}");

double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine($"Минимальное значение: {min}");

