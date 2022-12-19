// C# Seminar 2. HomeWork.
// Task 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int GetSecondNumber(int number)
{
    return number / 10 % 10;   
}

Console.Clear();
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 || num > 999) Console.WriteLine($"Введенное число {num} не трехзначное.");
else Console.WriteLine($"Вторая цифра числа {num} - {GetSecondNumber(num)}.");
