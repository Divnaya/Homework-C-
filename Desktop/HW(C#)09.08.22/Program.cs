/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа (456 -> 5, 782 -> 8, 918 -> 1).

Console.Clear();

int number = new Random().Next(100,1000);

Console.WriteLine(number);

int result = (number / 10) % 10;

// Console.Write("Вторая цифра этого числа: "); Console.WriteLine(result); */





//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// (645 -> 5, 78 -> третьей цифры нет, 32679 -> 6).

/*Console.Clear();

Console.Write("Введите число: ");

string number = Console.ReadLine();

char[] numberArray = number.ToCharArray();
if (numberArray.Length >= 3)
{
    Console.WriteLine("Третья цифра: "+numberArray[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
*/





// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, я
// является ли этот день выходным (6 -> да, 7 -> да, 1 -> нет).

Console.Clear();

Console.Write("Введите порядковый номер дня недели: ");

string[] days ={"Понедельник ","Вторник ","Среда ","Четверг ","Пятница ","Суббота ","Воскресенье "};
int number = int.Parse(Console.ReadLine());

if ((number == 6) | (number == 7)) {
    Console.WriteLine(days[number-1]+"- это выходной день");
}
else if ((number >= 1) & (number <= 5)) {
    Console.WriteLine(days[number-1]+"- это будний день");
}
else Console.WriteLine("Это число не соответствует заданному диапазону, так как в неделе всего 7 дней");





