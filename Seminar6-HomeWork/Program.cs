// C# Seminar 5. HomeWork.

// Task 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

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

// Task 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.


