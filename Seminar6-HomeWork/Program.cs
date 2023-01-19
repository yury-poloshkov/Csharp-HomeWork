// C# Seminar 5. HomeWork.

// Task 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int count_positive = 0;

Console.Clear();
Console.Write("Введите количество обрабатываемых чисел: ");
int numbers_quantity = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= numbers_quantity; i++)
{
    Console.Write($"Введите {i}-е число: ");
    if (Convert.ToInt32(Console.ReadLine()) > 0) count_positive++;
}
Console.WriteLine($"Количество положительных чисел: {count_positive}");
*/

// Task 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

double[] CalculateCrossPointCoordinates(double k1, double b1, double k2, double b2)
{
    double[] cross_point_coordinates = new double[2];
    cross_point_coordinates[0] = (b2 - b1) / (k1 - k2);
    cross_point_coordinates[1] = (k1 * b2 - b1 * k2) / (k1 - k2);
    return cross_point_coordinates;
}

void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(Math.Round(array[i],5) + " ");
    Console.WriteLine("");  
}

Console.Clear();
Console.WriteLine("Введите коэффициенты функции вида y = kx + b: ");
Console.WriteLine("- для первой прямой:");
Console.Write("  к1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("  b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("- для второй прямой:");
Console.Write("  k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("  b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1 != k2)
{
    double[] cross_point = CalculateCrossPointCoordinates(k1, b1, k2, b2);
    Console.Write("Координаты пересечения прямых с введенными параметрами :");
    PrintArray(cross_point);
}
else if (b1 == b2) Console.WriteLine("Введены параметры одной и той же прямой.");
else Console.WriteLine("Параллельные прямые не пересекаются.");
