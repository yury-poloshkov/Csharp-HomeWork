﻿// C# Seminar 1. HomeWork.

// Task 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2) Console.WriteLine("Введенные числа одинаковые!");
else
{
    int maximum = num1, minimum = num1;
    if (num2 > maximum) maximum = num2;
    else minimum = num2;
    Console.WriteLine($"Из введенных чисел большее: {maximum}, меньшее: {minimum}.");
}