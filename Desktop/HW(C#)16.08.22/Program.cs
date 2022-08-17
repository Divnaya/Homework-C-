// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵); 2, 4 -> 16

// Console.Clear();

// double PowNumber(int x, int y)
// {
//     double result = 1;
//     for (int i = 0; i < y; i++)
//     {
//         result *= x;
//     }
//     return result;
// }
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень, в которую хотите возвести: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(PowNumber(a, b)); - решение через функцию


// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень, в которую хотите возвести: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int result = a;

// for (int i = 0; i < b - 1; i++)
// {
//     result *= a; 
// }
// Console.WriteLine($"{a} в степени {b} = {result}"); - ещё один вариант решения


// int i = Convert.ToInt32(Math.Pow(a, b)); 
// Console.WriteLine("A^B = " + Math.Pow(a, b)); - один из вариантов решения через библиотеку.


// ___________________________________________________________________________________________________________________


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11, 82 -> 10, 9012 -> 12

// Console.Clear();

// int SumDigit(int a)
// {
//     int sum = 0;
//     while (a > 0)
//     {
//         sum += a % 10;
//         a /= 10;
//     }
//     return sum;
// }

// int num = new Random().Next();
// Console.WriteLine($"Сумма цифр в числе {num} = {SumDigit(num)}"); - решение через функцию


// int num = new Random().Next();
// Console.WriteLine(num);
// int sum = 0;

// while (num > 0)
// {
//     sum += num % 10;
//     num /= 10;
// }

// Console.WriteLine($"Сумма чисел = {sum}");


// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine()); - вариант с вводом от пользователя.


// ___________________________________________________________________________________________________________________


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]; 6, 1, 33 -> [6, 1, 33].

// Console.Clear();
// // int[] number = new int[8];
// // Console.Write("[");

// // for (int i = 0; i < number.Length; i++)
// // {
// //     number[i] = (new Random().Next());
// //     if (i != number.Length - 1)
// //     {
// //         Console.Write(number[i] + ", ");
// //     }
// // }
// // Console.WriteLine($"{number[number.Length -1]}]"); - вариант решения без функций

// int[] CreateArray()
// {
//     int[] a = new int[8];

//     for (int i = 0; i < a.Length; i++)
//     {
//         a[i] = (new Random().Next());
//     }
//     return a;
// }
// void PrintArray(int[] a)
// {
//     Console.Write("[");
//     for (int i = 0; i < a.Length; i++)
//     {
//         if (i != a.Length - 1)
//         {
//             Console.Write(a[i] + ", ");
//         }
//     }
//     Console.WriteLine($"{a[a.Length - 1]}]");
// }

// PrintArray(CreateArray());


// ___________________________________________________________________________________________________________________