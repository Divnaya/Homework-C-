/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.(14212 -> нет, 12821 -> да, 23432 -> да)*/

/*Console.Clear();
Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
void CheckingNumber(string number){
 if (number[0]==number[4] || number[1]==number[3]){
 Console.WriteLine($"Ваше число: {number} - является палиндромом.");
  }
 else Console.WriteLine($"Ваше число: {number} - не является палиндромом.");
}
if (number!.Length == 5){
 CheckingNumber(number);
}
else Console.WriteLine($"Вы ввели не пятизначное число.");
*/




/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

/*Console.Clear();

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
*/




/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

// Console.Clear();

// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine());

// for (int i = 1; i <= n; i++)
// {
    // Console.WriteLine(i * i * i);
// }
