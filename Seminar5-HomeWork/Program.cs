// C# Seminar 5. HomeWork.

// Task 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] GenerateRandomIntArray(int size, int minVal, int maxVal) 
{ 
    int[] array = new int[size];

    for (int i = 0; i < size; i++) 
        array[i] = new Random().Next(minVal, maxVal + 1);   
    
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine("");  
}

int CountEvenElements(int[] array)
{
    int even_counter = 0;

    for(int i =0; i < array.Length; i++)
        if(array[i] % 2 == 0) even_counter++;
    
    return even_counter; 
}

Console.Clear();
Console.Write("Введите размер одномерного массива: ");
int arr_length = Convert.ToInt32(Console.ReadLine());

int[] array = GenerateRandomIntArray(arr_length, 100, 999);
PrintArray(array);
int even_count = CountEvenElements(array);
Console.WriteLine($"Массив содержит {even_count} положительных чисел.");
*/

// Task 2. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] GenerateRandomIntArray(int size, int minVal, int maxVal) 
{ 
    int[] array = new int[size];

    for (int i = 0; i < size; i++) 
        array[i] = new Random().Next(minVal, maxVal + 1);   
    
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine("");  
}

int SumElementsOnNonevenPositions(int[] array)
{
    int sum = 0;

    for(int i =0; i < array.Length; i += 2)
        sum += array[i];
    
    return sum; 
}

Console.Clear();
Console.Write("Введите размер одномерного массива: ");
int arr_length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива: ");
int arr_min_value = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
int arr_max_value = Convert.ToInt32(Console.ReadLine());

int[] array = GenerateRandomIntArray(arr_length, arr_min_value, arr_max_value);
PrintArray(array);
int sum_noneven_positions = SumElementsOnNonevenPositions(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum_noneven_positions}");
*/

// Task 3. Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
/*
// Var.1 - Single complex function
double[] GenerateRandomDblArray(int size, double minVal, double maxVal) 
{ 
    double[] array = new double[size];

    for (int i = 0; i < size; i++) 
        array[i] = minVal + new Random().NextDouble() * (maxVal - minVal);   
    
    return array;
}

void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(Math.Round(array[i],5) + " ");
    Console.WriteLine("");  
}

double CountMinMaxElementsDifference(double[] array)
{
    double min = array[0];
    double max = array[0];    

    for(int i = 1; i < array.Length; i++)
        if(array[i] < min) min = array[i];
        else if(array[i] > max) max = array[i];
    
    return max - min; 
}

Console.Clear();
Console.Write("Введите размер одномерного массива: ");
int arr_length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива: ");
double arr_min_value = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
double arr_max_value = Convert.ToDouble(Console.ReadLine());

double[] array = GenerateRandomDblArray(arr_length, arr_min_value, arr_max_value);
PrintArray(array);
double min_max_difference = CountMinMaxElementsDifference(array);
Console.WriteLine($"Разность максимального и минимального элементов: {Math.Round(min_max_difference, 5)}");
*/

// Var.2 - Two simple functions

double[] GenerateRandomDblArray(int size, double minVal, double maxVal) 
{ 
    double[] array = new double[size];

    for (int i = 0; i < size; i++) 
        array[i] = minVal + new Random().NextDouble() * (maxVal - minVal);   
    
    return array;
}

void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(Math.Round(array[i],5) + " ");
    Console.WriteLine("");  
}

double FindMinElement(double[] array)
{
    double min = array[0];

    for(int i = 1; i < array.Length; i++)
        if(array[i] < min) min = array[i];
    
    return min; 
}

double FindMaxElement(double[] array)
{
    double max = array[0];

    for(int i = 1; i < array.Length; i++)
        if(array[i] > max) max = array[i];
    
    return max; 
}

Console.Clear();
Console.Write("Введите размер одномерного массива: ");
int arr_length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива: ");
double arr_min_value = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
double arr_max_value = Convert.ToDouble(Console.ReadLine());

double[] array = GenerateRandomDblArray(arr_length, arr_min_value, arr_max_value);
PrintArray(array);
double min = FindMinElement(array);
double max = FindMaxElement(array);
Console.WriteLine($"Разность максимального и минимального элементов: {Math.Round(max - min, 5)}");