//Задача 41.
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
//0, 7, 8, -2, -2 -> 2; 1, -7, 567, 89, 223-> 3

Console.Clear();
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



//__________________________________________________________________________________________________________________________________________________


//Задача 43.
//Напишите программу, которая найдёт точку пересечения двух прямых,заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
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
