// C#. Seminar9.HomeWork

// Task 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
/* 
void ShowNaturalDigitsDownLine(int number)
{
    Console.Write(number + " ");
    if (number > 1) ShowNaturalDigitsDownLine(number - 1);
    // if (number < -1) ShowNaturalDigitsDownLine(number + 1); // целые отрицательные - для теста, тоже работает 
} 

Console.Clear();
Console.Write("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0) ShowNaturalDigitsDownLine(number);
else Console.Write("В области отрицательных чисел натуральные отсутствуют."); 
Console.WriteLine();
 */
// Task 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/* 
// Вариант 1: в условиях задачи "в промежутке от M до N" -> M и N включаются в сумму!

int SumNaturalNumbersBetweenMandN(int m, int n)
{
    if (m < n) return m + SumNaturalNumbersBetweenMandN(m+1, n);
    else if (m > n) return n + SumNaturalNumbersBetweenMandN(m, n+1);
    else return m;
}

Console.Clear();
Console.Write("Введите первое натуральное число:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число:");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM > 0 && numberN >0)
{
    int sumNaturalNumbers = SumNaturalNumbersBetweenMandN(numberM, numberN); 
    Console.WriteLine($"Сумма натуральных чисел от {numberM} до {numberN} равна {sumNaturalNumbers}");
}
else Console.WriteLine("В области отрицательных чисел натуральные отсутствуют."); 
*/
// Вариант 2: в условиях задачи "в промежутке от M до N" -> M и N не включаются в сумму!
/* 
int SumNaturalNumbersBetweenMandN(int m, int n)
{
    if (m < n) return m + SumNaturalNumbersBetweenMandN(m+1, n);
    else return m;
}

Console.Clear();
Console.Write("Введите первое натуральное число:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число:");
int numberN = Convert.ToInt32(Console.ReadLine());

int sumNaturalNumbers = 0;

if (numberM > 0 && numberN >0)
{
    if (numberM < numberN - 1) 
        sumNaturalNumbers = SumNaturalNumbersBetweenMandN(numberM + 1, numberN -1); 
    else if (numberM > numberN + 1)
        sumNaturalNumbers = SumNaturalNumbersBetweenMandN(numberN +1, numberM -1);
    else
    {
        Console.WriteLine($"В промежутке между {numberM} и {numberN} натуральных чисел нет");   
    } 
    if (sumNaturalNumbers > 0)
        Console.WriteLine($"Сумма натуральных чисел в промежутке между {numberM} и {numberN} равна {sumNaturalNumbers}");
}
else Console.WriteLine("В области отрицательных чисел натуральные отсутствуют."); 
 */
// Task 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

double Akkerman(double n, double m)
{
    if (n > 0 && m > 0) return Akkerman(n-1, Akkerman(n, m-1));
    if (n > 0 && m == 0) return Akkerman(n-1, 1);
    if (n == 0 && m > 0) return m + 1;
    return 1;
}

Console.Clear();
Console.Write("Введите первое натуральное число:");
double numberN = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе натуральное число:");
double numberM = Convert.ToDouble(Console.ReadLine());

if (numberN < 0 || numberM < 0)
    Console.WriteLine("Функция Аккермана с отрицательными входными значениями не рассчитыввется.");
else 
{
    double akkermanNM = Akkerman(numberN, numberM);
    Console.WriteLine($"A({numberN},{numberM}) = {akkermanNM}");
}
