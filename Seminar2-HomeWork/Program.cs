// C# Seminar 2. HomeWork.
// Task 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int GetSecondNumber(int number)
{
    return number / 10 % 10;   
}

Console.Clear();
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(num) < 100 || Math.Abs(num) > 999) Console.WriteLine($"Введенное число {num} не трехзначное.");
else Console.WriteLine($"Вторая цифра числа {num} - {GetSecondNumber(Math.Abs(num))}.");
*/

// Task 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int GetThirdLeftNumber(int number)
{
    int numberlength = 0, numbercopy = number;
    while (numbercopy > 0)
    {
        numberlength++;
        numbercopy = numbercopy / 10;
    }
    return (number / (Convert.ToInt32(Math.Pow(10, numberlength-3)))) % 10;
}

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(num) < 100) Console.WriteLine($"В числе {num} нет третьей цифры.");
else Console.WriteLine($"Третья цифра числа {num} - {GetThirdLeftNumber(Math.Abs(num))}.");