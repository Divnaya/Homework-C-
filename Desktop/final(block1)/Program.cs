Console.Clear();
Console.WriteLine($"Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3.");
string[] array1;
string[] array2;
int count;
int j = 0;
Console.Write("Количество элеметов массива: ");
count = Int32.Parse(Console.ReadLine());
array1 = new string[count];
array2 = new string[count];
Console.WriteLine("Введите массив из строк:");
for (int i = 0; i < array1.Length; i++)
{
    Console.Write("Элемент массива [{0}] = ", i);
    array1[i] = Console.ReadLine();
}
for (int i = 0; i < array1.Length; i++)
    if (array1[i].Length <= 3)
    {
        array2[j] = array1[i];
        j++;
    }
Console.Write("Массив из строк, длина которых меньше либо равна 3: [  ");
for (int i = 0; i < array2.Length; i++)
    Console.Write("{0} ", array2[i]);
Console.Write("] ");
Console.ReadKey();

