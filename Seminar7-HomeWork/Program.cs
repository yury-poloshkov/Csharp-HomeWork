// Seminar7 - HomeWork.

// Common Methods

void Print2dIntArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine("");  
    }
    Console.WriteLine("");
}

void Print2dDblArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i, j],4) + "\t");
        Console.WriteLine("");  
    }
    Console.WriteLine("");
}

void PrintDblArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(Math.Round(array[i],5) + "\t");
    Console.WriteLine("");  
}

int[,] GenerateRandom2dIntArray(int rows, int columns, int minVal, int maxVal) 
{ 
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++) 
        for (int j = 0; j < columns; j++) 
            array[i, j] = new Random().Next(minVal, maxVal + 1);   
    
    return array;
}

// Specific Methods

// Task 3.  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] Create2dIntArray()
{
    Console.Write("Введите количество строк массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение элемента массива: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение элемента массива: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] array = GenerateRandom2dIntArray(rows, columns, minVal, maxVal);
    return array;
}

double[] CalculateColumnsAverages(int[,] array)
{
    double[] array_of_averages = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            array_of_averages[j] += array[i, j];
        array_of_averages[j] /= array.GetLength(0);
    }
    return array_of_averages;
}

Console.Clear();
int[,] testArray = Create2dIntArray();
Print2dIntArray(testArray);
double[] columnsAverages = CalculateColumnsAverages(testArray);
PrintDblArray(columnsAverages); 
*/

// Task 1.  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] GenerateRandom2dDblArray(int rows, int columns, double minVal, double maxVal) 
{ 
    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++) 
        for (int j = 0; j < columns; j++) 
            array[i, j] = minVal + new Random().NextDouble() * (maxVal - minVal);   
    
    return array;
}

double[,] Create2dDblArray()
{
    Console.Write("Введите количество строк массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение элемента массива: ");
    double minVal = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите максимальное значение элемента массива: ");
    double maxVal = Convert.ToDouble(Console.ReadLine());

    double[,] array = GenerateRandom2dDblArray(rows, columns, minVal, maxVal);
    return array;
}

Console.Clear();
double[,] testArray = Create2dDblArray();
Print2dDblArray(testArray);
*/

// Task 2.  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//          и возвращает значение этого элемента или же указание, что такого элемента нет.

int FindElement(int[,] array, ref int row, ref int column, ref string prefix) // используется для Варианта 1.
{
    try 
    {
        return array[row-1, column-1];        
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine($"Элемента с индексом [{row}, {column}] нет.");
        // ИЗЛИШНЕЕ, но...
        // так как метод должен что-то вернуть, то при выходе за границы массива
        // возвращаем один из следующих элементов:
        // - если row не выходит за предел массива - [row,array.GetLength(1)];
        // - если column не выходит за предел массива - [array.GetLength(0), column];
        // - иначе - [array.GetLength(0), array.GetLength(1)];
        // и {в основной программе} сообщаем, что нашли 
        // наиболее приближенный к запрашиваемой координате элемент.
        row = Math.Min(row, array.GetLength(0));
        column = Math.Min(column, array.GetLength(1));
        prefix = "наиболее близкой ";
        return array[row-1, column-1];
    }
}

Console.Clear();

Console.WriteLine("Введите позицию элемента массива : ");
Console.Write(" - строка: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write(" - столбец: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

int[,] testArray = GenerateRandom2dIntArray(new Random().Next(2,11), new Random().Next(2,11), 
                                            new Random().Next(-10,-2), new Random().Next(2,11));
Console.WriteLine("В сгенерированном массиве случайной размерности:");
Print2dIntArray(testArray);

// Вариант 1. С использованием метода FindElement.
string prefix = "";
int foundElement = FindElement(testArray, ref row, ref column, ref prefix);
Console.WriteLine($"Элемент на {prefix}позиции [{row}, {column}] = {foundElement}");

/* Вариант 2. Без использования дополнительного метода. 
int foundElement = 0;
try
{
    foundElement = testArray[row-1, column -1];
    Console.WriteLine($"Элемент на позиции [{row}, {column}] = {foundElement}");
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine($"Элемента с индексом [{row}, {column}] нет.");
}    
Console.WriteLine($"Элемент на позиции [{row}, {column}] = {foundElement}");
*/