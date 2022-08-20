/* Задача 34.
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2 */

/*Console.Clear();
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
    */

    // _________________________________________________________________________________________________________________________________________________


/*Задача 36.
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0.*/

/*Console.Clear();
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
*/

// __________________________________________________________________________________________________________________________________________________


/*Задача 38.
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76 */

Console.Clear();
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