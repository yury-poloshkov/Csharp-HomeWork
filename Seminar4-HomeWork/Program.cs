// C# Seminar 3. HomeWork.

// Task 1. Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
/*
double CalculateExponent(int foot, int degree) 
{
    double exponenta = 1;
    if (degree == 0) return exponenta;

    for(int i = 1; i <= Math.Abs(degree); i++)
        exponenta *= foot;

    if (degree < 0) exponenta = 1 / exponenta;
    return exponenta;
}

Console.Clear();
Console.Write("Введите основание: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());

double a_exp_b = CalculateExponent(a, b);
Console.WriteLine($"{a}^{b} = {Math.Round(a_exp_b, 5)}");
*/

// Task 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int CalcNumSum(long number)
{
    int number_sum = 0;
    number = Math.Abs(number);
    while (number > 0)
    {
        number_sum += Convert.ToInt32(number % 10);
        number /= 10;
    }
    return number_sum;
}

Console.Clear();
Console.Write("Введите число: ");
long num = Convert.ToInt64(Console.ReadLine());

int num_sum = CalcNumSum(num);
Console.WriteLine($"Сумма цифр числа {num} равна {num_sum}.");
*/

// Task 3. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] InputArray(int size)
{
    int[] array = new int[size];

    Console.WriteLine($"Последовательно введите {size} элементов массива:");

    for(int i = 0; i < size; i++)
    {
        Console.Write($"{i+1}-й элемент: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine("");  
}

Console.Clear();
Console.Write("Введите размер одномерного массива: ");
int arr_length = Convert.ToInt32(Console.ReadLine());

int[] handmade_array = InputArray(arr_length);

PrintArray(handmade_array);