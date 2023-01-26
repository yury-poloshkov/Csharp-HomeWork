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

void PrintIntArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
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

// Specific Part

// Task 1. Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int FindMaxItemIndexInRow(int[,] array, int row, int startingPosition)
{
    int maxItemIndex = startingPosition;
    int maxItem = array[row, maxItemIndex];

    for (int j = startingPosition + 1; j < array.GetLength(1); j++)
        if (array[row, j] > maxItem) 
        {
            maxItemIndex = j;
            maxItem = array[row, maxItemIndex];
        }
    return maxItemIndex; 
}

void SortRowsOfArrayDecreasing(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int maxItemIndex = FindMaxItemIndexInRow(array, i, j);
            if (maxItemIndex > j)
            {
                int temp = array[i,j];
                array[i,j] = array[i, maxItemIndex];
                array[i, maxItemIndex] = temp;
            }            
        }
    }
}

Console.Clear();
int[,] testArray = Create2dIntArray();
Print2dIntArray(testArray);
SortRowsOfArrayDecreasing(testArray);
Print2dIntArray(testArray);
*/

// Task 2. Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов. 
/*
int[] CalculateRowsSums(int[,] array)
{
    int[] arrayOfRowsSums = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++) arrayOfRowsSums[i] += array[i, j];
    return arrayOfRowsSums;
}

int FindMinItemIndex(int[] array)
{
    int minItemIndex = 0;
    int min = array[minItemIndex];

    for(int i = 1; i < array.Length; i++)
        if(array[i] < min)
        {
            minItemIndex = i;
            min = array[minItemIndex];
        }    
    return minItemIndex; 
}

Console.Clear();
int[,] testArray = Create2dIntArray();
Print2dIntArray(testArray);
int[] arrayOfRowsSums = CalculateRowsSums(testArray);
PrintIntArray(arrayOfRowsSums);
int minRowSumIndex = FindMinItemIndex(arrayOfRowsSums);
Console.WriteLine($"Минимальная сумма элементов: {arrayOfRowsSums[minRowSumIndex]} - в строке {minRowSumIndex + 1}");
*/

// Task 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. 
/*
int[,] MultiplyMatrixes(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] multiplicatedMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

    for (int i = 0; i < firstMatrix.GetLength(0); i++)
        for (int j =0; j <secondMatrix.GetLength(1); j++)
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
                multiplicatedMatrix[i,j] += firstMatrix[i,k] * secondMatrix[k,j];
    return multiplicatedMatrix;
}

Console.Clear();
Console.WriteLine("Задайте параметры первой матрицы:");
int[,] firstMatrix = Create2dIntArray();
Console.WriteLine();
Console.WriteLine($"Задайте параметры второй матрицы, совместимой с первой (количество строк в ней должно быть {firstMatrix.GetLength(1)}):");
int[,] secondMatrix = Create2dIntArray();
Console.WriteLine();

if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0)) 
{
    int[,] multiplicatedMatrix = MultiplyMatrixes(firstMatrix, secondMatrix);
    Console.WriteLine("Результатом умножения матриц:");
    Print2dIntArray(firstMatrix);
    Print2dIntArray(secondMatrix);
    Console.WriteLine("является матрица:");
    Print2dIntArray(multiplicatedMatrix);
}
else Console.WriteLine("Матрицы несовместимы и не могут быть перемножены.");
*/

// Task 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
void Print3dIntArray(int[,,] array)
{
    for(int k = 0; k < array.GetLength(2); k++)
    {
        Console.WriteLine($"{k+1}-й вертикальный слой матрицы:");
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i, j, k] + "\t");
            Console.WriteLine("");  
        }
        Console.WriteLine("");
    } 
}

int[,,] Fill3dArray(int rows, int columns, int depth)
{
    int[,,] array = new int[rows, columns, depth];
    
    int[] arrayOf2DigitNums = new int[90];

    for (int digit = 10; digit <= 99; digit++)
        arrayOf2DigitNums[digit - 10] = digit;

    int free2DigitNums = 90;

    for (int i = 0; i < rows; i++)
        for (int j =0; j < columns; j++)
            for (int k = 0; k < depth; k++)
            {
                int index = new Random().Next(0,free2DigitNums);
                array[i,j,k] = arrayOf2DigitNums[index];
                arrayOf2DigitNums[index] = arrayOf2DigitNums[free2DigitNums-1];
                free2DigitNums--;
            }
    return array;
}

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество вертикальных слоев массива: ");
int depth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (rows * columns * depth <= 90)
{
    int[,,] testArray = Fill3dArray(rows, columns, depth);
    Print3dIntArray(testArray);
}
else 
{
    Console.WriteLine($"Массив не может быть заполнен неповторяющимися двузначными числами, так как ");
    Console.WriteLine($"количество его элементов на {rows * columns * depth - 90} больше количества двузначных чисел.");
    Console.WriteLine();
}
*/

// Task 5. Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int curRow = 0;
int curCol = 0;
int rowStep = 0;
int colStep = 1;

int[,] testArray = new int[rows, columns];

for (int i = 1; i <= rows * columns; i++)
{    
    testArray[curRow, curCol] = i;
    
    switch (2 * rowStep + colStep)
    {
        case 1: // движение вправо
            if (curCol+colStep == columns || testArray[curRow+rowStep, curCol+colStep] > 0)
            {
                rowStep = 1; // следующим шагом
                colStep = 0; // двигаемся вниз
            }              
            break;
        case 2: // движение вниз
            if (curRow+rowStep == rows || testArray[curRow+rowStep, curCol+colStep] > 0)
            {
                rowStep = 0;  // следующим шагом
                colStep = -1; // двигаемся влево
            }
            break;        
        case -1: // движение влево
            if (curCol+colStep < 0 || testArray[curRow+rowStep, curCol+colStep] > 0)
            {
                rowStep = -1;  // следующим шагом
                colStep = 0; // двигаемся вверх
            }
            break;
        case -2: // движение вверх
            if (curRow+rowStep < 0 || testArray[curRow+rowStep, curCol+colStep] > 0)
            {
                rowStep = 0;  // следующим шагом
                colStep = 1; // двигаемся вправо
            }
            break;
    }
    curRow += rowStep;
    curCol += colStep;
}
Print2dIntArray(testArray);