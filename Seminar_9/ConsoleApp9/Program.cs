//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintNum(n);

void PrintNum(int n)
{
    if (n == 0)
    {
        return;
    }
    Console.Write(n + " ");
    PrintNum(n-1);
}


//Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("Введите число M: "); 
int M = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите число N: "); 
int N = Convert.ToInt32(Console.ReadLine()); 
int count = 0;  
int stop_count = 0;
int sum = 0;

if (N>M)
{
    count=M;
    stop_count=N;
}

else
{
    count=N;
    stop_count=M;
}

int PrintNumber() 
{   
    if(count>stop_count)  
    {    
        return count;   
    }  

    Console.Write(count+" ");    
    sum = sum+count;
    count++;  
    return (PrintNumber()); 
}  

PrintNumber();

Console.WriteLine();
Console.Write($"Cумма натуральных элементов в промежутке от M до N = {sum}");


//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
Console.Write("Введите число M: "); 
int M = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите число N: "); 
int N = Convert.ToInt32(Console.ReadLine()); 

int AckermannFunction (int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return AckermannFunction(M - 1, 1);
    if (M > 0 && N > 0) return AckermannFunction(M - 1, AckermannFunction(M, N - 1));
    return AckermannFunction(M, N);
}

Console.WriteLine($"Функция Аккермана для чисел A({M},{N}) = {AckermannFunction(M, N)}");
