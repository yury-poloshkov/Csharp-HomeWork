// Seminar8.HomeWork

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

int[,] GenerateRandom2dIntArray(int rows, int columns, int minVal, int maxVal) 
{ 
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++) 
        for (int j = 0; j < columns; j++) 
            array[i, j] = new Random().Next(minVal, maxVal + 1);   
    
    return array;
}






// Specific Methods

// Task 1. Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.


// Task 2. Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов. 

// Task 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. 

// Task 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Task 5. Напишите программу, которая заполнит спирально массив 4 на 4.