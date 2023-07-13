//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Задайте количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] twoDimensArray = new double[m, n];

Random random = new Random();

void PrintArray(double[,] matrix)
{ 
    for (int i = 0; i < m; i++)
    { 
        for (int j = 0; j < n; j++)
        { 
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
 }

void FillArray(double[,] matrix)
{ 
    for (int i = 0; i < m; i++)
    { 
        for (int j = 0; j < n; j++)
        { 
            matrix[i,j] = Convert.ToDouble(random.Next(-100, 100)/10.0);
        }
    }
}
FillArray(twoDimensArray);

Console.WriteLine();

PrintArray(twoDimensArray);


//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Случайный массив:");
int[,] matrix = new int[5, 5];
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(10, 100);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray(matrix);

Console.Write("Введите строку: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.Write("Введите столбец: ");
int columns = int.Parse(Console.ReadLine());

try
{
    Console.WriteLine($"Элемент находящийся в строке {rows} и в столбце {columns} имеет значение : " + matrix[rows, columns]);
}
catch (System.Exception)
{
    Console.WriteLine("В массиве нет такого элемента");
    Environment.Exit(1);
}

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] array = new int [5,5];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1,5);
        Console.Write(array[i, j] + " ");
    }

    Console.WriteLine();
}

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    double avarageResult = 0.0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i,j];
    }
    avarageResult = (double) sum / array.GetLength(1);
    Console.WriteLine($"Среднее арифметическое строки: {avarageResult}");
}



