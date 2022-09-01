//                                      СЕМИНАР №1 Знакомство с языком программирования С#
// _____________________________________________________________________________________________________________________________________________________
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// _____________________________________________________________________________________________________________________________________________________
Console.Clear();
Console.WriteLine($"Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine("Первое число " + firstNumber + " больше чем второе " + secondNumber);
}
else
{
    Console.WriteLine("Второе число " + secondNumber + " больше чем первое " + firstNumber);
}
// _____________________________________________________________________________________________________________________________________________________
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
// _____________________________________________________________________________________________________________________________________________________
Console.Clear();
Console.WriteLine($"Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.WriteLine("Введите 3 числа:");
int num_1 = Convert.ToInt32(Console.ReadLine());
int num_2 = Convert.ToInt32(Console.ReadLine());
int num_3 = Convert.ToInt32(Console.ReadLine());
int max = num_1;
if (num_2 > max)
{
    max = num_2;
}
if (num_3 > max)
{
    max = num_3;
}
Console.WriteLine("Наибольшее из введённых чисел -> " + max);
// ____________________________________________________________________________________________________________________________________________________
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
// ____________________________________________________________________________________________________________________________________________________
Console.Clear();
Console.WriteLine($"Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.");
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 1)
            {
                Console.WriteLine("Число " + number + " является: НЕЧЁТНЫМ");
            }
            else
            {
                Console.WriteLine("Число " + number + "является: ЧЁТНЫМ");
            }
// _____________________________________________________________________________________________________________________________________________________
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
// _____________________________________________________________________________________________________________________________________________________
Console.Clear();
Console.WriteLine($"Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 1;
Console.WriteLine("Чётные числа от 1 до " + number);
while (index <= number)
{
    if (index % 2 != 1)
    {
        Console.Write(index + ", ");
    }
    index++;
}
// _____________________________________________________________________________________________________________________________________________________
//                                      СЕМИНАР №2 Массивы и функции в программировании
// _____________________________________________________________________________________________________________________________________________________
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// _____________________________________________________________________________________________________________________________________________________
Console.Clear();
Console.WriteLine($"Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
int number = new Random().Next(100,1000);
Console.WriteLine(number);
int result = (number / 10) % 10;
Console.Write("Вторая цифра этого числа: "); Console.WriteLine(result);
// _____________________________________________________________________________________________________________________________________________________
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// _____________________________________________________________________________________________________________________________________________________
Console.Clear();
Console.WriteLine("Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.Write("Введите число: ");
string number = Console.ReadLine();
char[] numberArray = number.ToCharArray();
if (numberArray.Length >= 3)
{
    Console.WriteLine("Третья цифра: " + numberArray[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
// _____________________________________________________________________________________________________________________________________________________
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// _____________________________________________________________________________________________________________________________________________________
Console.Clear();
Console.WriteLine("Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходнымт.");
Console.Write("Введите порядковый номер дня недели: ");
string[] days = { "Понедельник ", "Вторник ", "Среда ", "Четверг ", "Пятница ", "Суббота ", "Воскресенье " };
int number = int.Parse(Console.ReadLine());
if ((number == 6) | (number == 7))
{
    Console.WriteLine(days[number - 1] + "- это выходной день");
}
else if ((number >= 1) & (number <= 5))
{
    Console.WriteLine(days[number - 1] + "- это будний день");
}
else Console.WriteLine("Это число не соответствует заданному диапазону, так как в неделе всего 7 дней");
// _____________________________________________________________________________________________________________________________________________________
//                                      СЕМИНАР №3 Массивы и функции в программировании
// _____________________________________________________________________________________________________________________________________________________
// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// _____________________________________________________________________________________________________________________________________________________
Console.Clear();
Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом");
Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
void CheckingNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Ваше число: {number} - является палиндромом.");
    }
    else Console.WriteLine($"Ваше число: {number} - не является палиндромом.");
}
if (number!.Length == 5)
{
    CheckingNumber(number);
}
else Console.WriteLine($"Вы ввели не пятизначное число.");
// _____________________________________________________________________________________________________________________________________________________
// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// _____________________________________________________________________________________________________________________________________________________
Console.Clear();
Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
Console.WriteLine("Введите координаты точки А: ");
Console.Write("X = ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y = ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Z = ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
Console.Write("X = ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y = ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Z = ");
double z2 = Convert.ToDouble(Console.ReadLine());
double result = Math.Sqrt(Math.Pow((x1 - x2), 2)
              + Math.Pow((y1 - y2), 2)
              + Math.Pow((z1 - z2), 2));
Console.WriteLine($"Расстояние между точками A и B в 3D пространстве = {result:F}");
// _____________________________________________________________________________________________________________________________________________________
// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// _____________________________________________________________________________________________________________________________________________________
Console.Clear();
Console.WriteLine("Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N");
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine(i * i * i);
}
// _____________________________________________________________________________________________________________________________________________________
//                                      СЕМИНАР №4 Функции продолжение
// _____________________________________________________________________________________________________________________________________________________
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// _____________________________________________________________________________________________________________________________________________________
Console.Clear();
Console.WriteLine("Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B");
double PowNumber(int x, int y)
{
    double result = 1;
    for (int i = 0; i < y; i++)
    {
        result *= x;
    }
    return result;
}
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень, в которую хотите возвести: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PowNumber(a, b));
// _____________________________________________________________________________________________________________________________________________________
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// _____________________________________________________________________________________________________________________________________________________
Console.Clear();
Console.WriteLine("Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
int SumDigit(int a)
{
    int sum = 0;
    while (a > 0)
    {
        sum += a % 10;
        a /= 10;
    }
    return sum;
}
int num = new Random().Next();
Console.WriteLine($"Сумма цифр в числе {num} = {SumDigit(num)}");
// _____________________________________________________________________________________________________________________________________________________
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// _____________________________________________________________________________________________________________________________________________________
Console.Clear();
Console.WriteLine(" Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");
int[] CreateArray()
{
    int[] a = new int[8];

    for (int i = 0; i < a.Length; i++)
    {
        a[i] = (new Random().Next());
    }
    return a;
}
void PrintArray(int[] a)
{
    Console.Write("[");
    for (int i = 0; i < a.Length; i++)
    {
        if (i != a.Length - 1)
        {
            Console.Write(a[i] + ", ");
        }
    }
    Console.WriteLine($"{a[a.Length - 1]}]");
}
PrintArray(CreateArray());
// _____________________________________________________________________________________________________________________________________________________
//                                      СЕМИНАР №5 Функции продолжение
// _____________________________________________________________________________________________________________________________________________________
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел 
// в массиве. [345, 897, 568, 234] -> 2
// _____________________________________________________________________________________________________________________________________________________
Console.Clear();
Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами.");
Console.WriteLine("Напишите программу, которая покажет количество чётных чисел в массиве.");
int positivArray(int lengthArray, int minRandom, int maxRandom)
{
    int[] a = new int[lengthArray];
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(minRandom, maxRandom);
        Console.Write(a[i] + " ");
        if (a[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine();
    return count;
}
Console.WriteLine("Вводите трёхзначные положительные числа! ");
Console.Write("Укажите длину массива: ");
int length1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение для анализа: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение для анализа: ");
int max1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество четных чисел в массиве = " + positivArray(length1, min1, ++max1));
Console.WriteLine();
// _____________________________________________________________________________________________________________________________________________________
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// _____________________________________________________________________________________________________________________________________________________
Console.Clear();
Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
int SumArray(int lengthArray, int minRandom, int maxRandom)
{
    int[] ab = new int[lengthArray];
    int sum = 0;
    for (int index = 0; index < ab.Length; index++)
    {
        ab[index] = new Random().Next(minRandom, maxRandom);
        Console.Write(ab[index] + " ");
        if (index % 2 == 0)
        {                   
            sum += ab[index];
        }
    }
    Console.WriteLine();
    return sum;
}
Console.Write("Укажите длину массива: ");
int length2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма элементов на нечётных позициях = " + SumArray(length2, min2, ++max2));
Console.WriteLine();
// _____________________________________________________________________________________________________________________________________________________
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// _____________________________________________________________________________________________________________________________________________________
Console.Clear();
Console.WriteLine("Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массиваю.");
void MaterialArray(int lengthArray)
{
    double[] d = new double[lengthArray];
    double max = 0;
    double min = 1;
    for (int ind = 0; ind < d.Length; ind++)
    {
        d[ind] = new Random().NextDouble();
        Console.Write(Math.Round(d[ind], 2) + " ");
        if (d[ind] > max)
        {
            max = d[ind];
        }
    }
    min = max;
    for (int ind = 0; ind < d.Length; ind++)
    {
        if (d[ind] < min)
        {
            min = d[ind];
        }
    }
    Console.WriteLine();
    Console.WriteLine("Максимальный элемент = " + Math.Round(max, 2));
    Console.WriteLine("Минимальный элемент = " + Math.Round(min, 2));
    Console.WriteLine("Разница между максимальным и минимальным элементом массива = " + Math.Round((max - min), 2));
}
Console.Write("Введите длину массива: ");
int length3 = Convert.ToInt32(Console.ReadLine());
MaterialArray(length3);
Console.WriteLine();
// _____________________________________________________________________________________________________________________________________________________
//                                      СЕМИНАР №6 Двумерные массивы и рекурсия
// _____________________________________________________________________________________________________________________________________________________
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// _____________________________________________________________________________________________________________________________________________________
Console.Clear();
Console.WriteLine("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь");
int CountGreaterZero(int[] a)
{
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] > 0) count++;
    }
    return count;
}
int[] CreateArray(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
Console.Write("Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество чисел после нуля = {CountGreaterZero(CreateArray(n))}");
// _____________________________________________________________________________________________________________________________________________________
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// _____________________________________________________________________________________________________________________________________________________
Console.Clear();
Console.WriteLine("Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями.");
double[] StraightA(double b1, double k1)
{
    double[] straight1 = new double[2];
    straight1[0] = b1;
    straight1[1] = k1;
    return straight1;
}
double[] StraightB(double b2, double k2)
{
    double[] straight2 = new double[2];
    straight2[0] = b2;
    straight2[1] = k2;
    return straight2;
}
double[] IntersectionPoint(double[] a, double[] b)
{
    double x = 0;
    double[] xp = new double[4];
    double y;
    xp[0] = a[0];
    xp[1] = a[1];
    xp[2] = b[0];
    xp[3] = b[1];
    x += (xp[3] - xp[1]) / (xp[0] - xp[2]);
    y = a[0] * ((xp[3] - xp[1]) / (xp[0] - xp[2])) + xp[1];
    double[] result = new double[2];
    result[0] = x;
    result[1] = y;
    return result;
}
void ShowResult(double[] res)
{
    for (int i = 0; i < res.Length; i++)
    {
        if (i == 0) Console.Write($"x = {Math.Round(res[i], 2)}; ");
        else Console.Write($"y = {Math.Round(res[i], 2)}");
    }
}
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
ShowResult(IntersectionPoint(StraightA(k1, b1), StraightB(k2, b2)));
Console.WriteLine();
// _____________________________________________________________________________________________________________________________________________________
//                                      СЕМИНАР №7 Как не нужно писать код. Часть 1
// _____________________________________________________________________________________________________________________________________________________
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// _____________________________________________________________________________________________________________________________________________________
Console.Clear();
Console.WriteLine("Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
double[,] CreateArray(int size1, int size2)
{
    double[,] randomArray = new double[size1, size2];
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i, j] = new Random().NextDouble();
        }
    }
    return randomArray;
}
void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(Math.Round(arr[i, j], 2) + " ");
        }
        Console.WriteLine();
    }
}
Console.Write($"Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintArray(CreateArray(m, n));
// _____________________________________________________________________________________________________________________________________________________
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// _____________________________________________________________________________________________________________________________________________________
Console.Clear();
Console.WriteLine("Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, ");
Console.WriteLine("что такого элемента нет.");
int[,] RandomArray()
{
    int[,] rndmArray = new int[new Random().Next(5, 11), new Random().Next(5, 11)];
    for (int i = 0; i < rndmArray.GetLength(0); i++)
    {
        for (int j = 0; j < rndmArray.GetLength(1); j++)
        {
            rndmArray[i, j] = new Random().Next(1, 100);
        }
    }
    return rndmArray;
}
void ShowElement(int[,] array, int pos1, int pos2)
{
    int a = array.GetLength(0);
    int b = array.GetLength(1);
    if (pos1 <= a && pos2 <= b && pos1 > 0 && pos2 > 0)
    {
        Console.WriteLine($"Позиция элемента {pos1} {pos2} = {array[pos1 - 1, pos2 - 1]}");
    }
    else
    {
        Console.WriteLine($"Нет такого элемента в заданной позиции {pos1} {pos2}");
    }
}
Console.Write("Введите первую позицию: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую позицию: ");
int y = Convert.ToInt32(Console.ReadLine());
ShowElement(RandomArray(), x, y);
// _____________________________________________________________________________________________________________________________________________________
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// _____________________________________________________________________________________________________________________________________________________
Console.Clear();
Console.WriteLine("Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
int[,] CreateArr()
{
    int[,] arra = new int[new Random().Next(5, 11), new Random().Next(5, 11)];
    for (int i = 0; i < arra.GetLength(0); i++)
    {
        for (int j = 0; j < arra.GetLength(1); j++)
        {
            arra[i, j] = new Random().Next(1, 101);
            Console.Write(arra[i, j] + " ");
        }
        Console.WriteLine();
    }
    return arra;
}
double[] MOC(int[,] ar)
{
    double sum = 0;
    int size = ar.GetLength(0);
    double[] average = new double[ar.GetLength(1)];
    int x = 0;
    for (int i = 0; i < average.Length; i++)
    {
        for (int j = 0; j < ar.GetLength(0); j++)
        {
            sum += ar[j, x];
            for (int g = 0; g < ar.GetLength(1); g++)
            {
                average[i] = sum / size;
            }
        }
        x++;
        sum = 0;
    }
    return average;
}
void PrintMOC(double[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write(Math.Round(a[i], 2) + " ");
    }
    Console.WriteLine();
}
PrintMOC(MOC(CreateArr()));
// _____________________________________________________________________________________________________________________________________________________
//                                      СЕМИНАР №8 Как не нужно писать код. Часть 2
// _____________________________________________________________________________________________________________________________________________________
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// _____________________________________________________________________________________________________________________________________________________
Console.Clear();
Console.WriteLine("Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
int[,] CreateArray(int size1, int size2)
{
    int[,] rndArray = new int[size1, size2];
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            rndArray[i, j] = new Random().Next(1, 101);
        }
    }
    return rndArray;
}
void ShowOriginArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] SortArray(int[,] array)
{
    for (int g = 0; g < array.GetLength(1); g++)
    {
        int x = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[x, j] > array[x, j + 1])
                {
                    int temp = array[x, j];
                    array[x, j] = array[x, j + 1];
                    array[x, j + 1] = temp;
                }
            }
            x++;
        }
    }
    return array;
}
void ShowSortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк: ");
int stringsCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columnsCount = Convert.ToInt32(Console.ReadLine());
int[,] newArray = CreateArray(stringsCount, columnsCount);
ShowOriginArray(newArray);
Console.WriteLine();
ShowSortArray(SortArray(newArray));
// _____________________________________________________________________________________________________________________________________________________
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// _____________________________________________________________________________________________________________________________________________________
Console.Clear();
Console.WriteLine("Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
int[,] CreateArra(int size1, int size2)
{
    int[,] array = new int[size1, size2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 101);
        }
    }
    return array;
}
int[] SumInString(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    int x = 0;
    int summ = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int g = 0; g < array.GetLength(1); g++)
            {
                summ += array[x, g];
                sum[i] = summ;
            }
            summ = 0;
        }
        x++;
    }
    return sum;
}
void PrintSum(int[] sum)
{
    for (int i = 0; i < sum.Length; i++)
    {
        Console.Write(sum[i] + " ");
    }
    Console.WriteLine();
}
void PrintArra(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int MinSumInString(int[] sum)
{
    int min = sum[0];
    int minIndex = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        if (sum[i] <= min)
        {
            min = sum[i];
            minIndex = i + 1;
        }
    }
    return minIndex;
}
Console.Write("Введите количество строк: ");
int stringCounts = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columnsCounts = Convert.ToInt32(Console.ReadLine());
while (stringCounts == columnsCounts)
{
    Console.WriteLine("Ошибка, массив должен быть прямоугольным!");
    Console.Write("Введите количество строк: ");
    stringCounts = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    columnsCounts = Convert.ToInt32(Console.ReadLine());
}
int[,] array = CreateArra(stringCounts, columnsCounts);
PrintArra(array);
Console.WriteLine();
PrintSum(SumInString(array));
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов в строке: {MinSumInString(SumInString(array))}");
// _____________________________________________________________________________________________________________________________________________________
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// _____________________________________________________________________________________________________________________________________________________
Console.Clear();
Console.WriteLine("Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
Console.WriteLine($"\nВведите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[m, p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
// _____________________________________________________________________________________________________________________________________________________
// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
// _____________________________________________________________________________________________________________________________________________________
Console.Clear();
Console.WriteLine("Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,");
Console.WriteLine("добавляя индексы каждого элемента.");
Console.WriteLine($"\nВведите размер массива X x Y x Z:");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine($"");

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void WriteArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.Write($"X({i}) Y({j}) ");
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"Z({k})={array3D[i, j, k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void CreateArray(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}
// _____________________________________________________________________________________________________________________________________________________
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
// _____________________________________________________________________________________________________________________________________________________
Console.Clear();
Console.WriteLine("Напишите программу, которая заполнит спирально массив 4 на 4.");
int[,] SpiralArray()
{
    int n = 4;
    int m = 4;
    int[,] array = new int[n, m];
    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0;
    int visits = m;
    for (int i = 0; i < array.Length; i++)
    {
        array[row, col] = i + 1;
        if (--visits == 0)
        {
            visits = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        col += dx;
        row += dy;
    }
    return array;
}
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
ShowArray(SpiralArray());
// _____________________________________________________________________________________________________________________________________________________