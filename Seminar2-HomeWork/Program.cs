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
/*
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
*/

// Task 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

bool IsWeekEnd(int week_day_number)
{
    if (week_day_number < 6) return false;
    else return true;
}

Console.Clear();
Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1 || num > 7) Console.WriteLine($"Стандартная неделя насчитывает 7 дней, а никак не {num}.");
else 
{
    if (IsWeekEnd(num)) Console.WriteLine("Ура, выходной!!!");
    else Console.WriteLine("Увы, придется идти на работу.");
}