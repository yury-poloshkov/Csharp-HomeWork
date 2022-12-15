// C# Seminar 1. HomeWork.

// Task 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
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
*/

// Task 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Clear();
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int maximum = num1;
if (num2 > maximum) maximum = num2;
if (num3 > maximum) maximum = num3;

Console.WriteLine($"Из введенных чисел максимальное: {maximum}.");
*/

// Task 3. Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string prefix = "";
if (num % 2 == 1) prefix = "не";
Console.WriteLine($"Введенное число {prefix}четное.");