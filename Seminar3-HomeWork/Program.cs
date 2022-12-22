// C# Seminar 2. HomeWork.

/*
// Task 1. Напишите программу, которая принимает на вход (*пятизначное*) число 
// и проверяет, является ли оно палиндромом.

bool IsPalindrom (long number)
{
    long cuted_number = number;
    long revered_number = 0;
     while (cuted_number != 0)
    {
        revered_number = revered_number * 10 + cuted_number % 10;
        cuted_number /= 10; 
    }
    if (number == revered_number) return true;
    else return false;
}

Console.Clear();
Console.Write("Введите число: ");
long num = Convert.ToInt64(Console.ReadLine());

string prefix = " ";
if (!IsPalindrom(num)) prefix = " не ";
Console.WriteLine($"Введенное число -{prefix}палиндром.");
*/

/*
// Task 2. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

double LineLength(double x1, double y1, double z1, double x2, double y2, double z2, int length_after_dot)
{
    return Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)), length_after_dot);
}

Console.Clear();
Console.WriteLine("Введите координаты 2-х точек в 3-х мерном пространстве: ");
Console.Write("x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите количество знаков после запятой: ");
int length_after_dot = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Длина отрезка - {LineLength(x1, y1, z1, x2, y2, z2, length_after_dot)}");
*/

// Task 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void CombineCubicTable (int number)
{
    int cur_number = 1;
    string prefix = "";
    if (number < 0) prefix = "-";
    while (cur_number <= Math.Abs(number))
    {
        Console.Write(prefix + Math.Pow(cur_number, 3) + " ");
        cur_number++;
    }
    Console.WriteLine("");
}

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num !=0) CombineCubicTable(num);
else Console.WriteLine("Сколько ноль не умножай, больше ноля не получится!");