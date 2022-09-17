// Console.Clear();


// string[] array1; // массив строк
// int count; // количество элементов в массиве
// int j = 0; // счетчик для второго массива
// string[] array2; // массив результат

// // 2. Ввести количество строк
// Console.Write("Количетво элеметов массива: ");
// count = Int32.Parse(Console.ReadLine());

// // 3. Выделить память для массива из count строк
// array1 = new string[count];
// array2 = new string[count];

// // 4. Ввести данные массива с клавиатуры
// Console.WriteLine("Ввод исходного массива:");

// for (int i = 0; i < array1.Length; i++)
// {
//     Console.Write("Элемент массива [{0}] = ", i);
//     array1[i] = Console.ReadLine();
// }

// // 5. Сортировка массива
// for (int i = 0; i < array1.Length; i++)
//     if (array1[i].Length >= 3)
//     {
//         array2[j] = array1[i];
//         j++;
//     }


// Console.WriteLine("Массив элементов новый: ");
// for (int i = 0; i < array2.Length; i++)
//     Console.Write("{0} , ", array2[i]);
// Console.ReadKey();








string[] arrayFirst = { "labas", "hi", "pryvitannie", "privet", "Ey" };
int countFirst = CountStringLessThreeChar(arrayFirst);
string[] resultFirst = FillResultArray(arrayFirst, countFirst);


string[] arraySecond = { "333", "16", "-41", "my_sun", "abcd" };
int countSecond = CountStringLessThreeChar(arraySecond);
string[] resultSecond = FillResultArray(arraySecond, countSecond);


string[] arrayThird = { "Poland", "Lithuania", "Belarus", "OAE" };
int countThird = CountStringLessThreeChar(arrayThird);
string[] resultThird = FillResultArray(arrayThird, countThird);

void PrintArray(string[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}.");
    }
    Console.WriteLine();
}

int CountStringLessThreeChar(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] FillResultArray(string[] array, int count)
{
    string[] result = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[result.Length - count] = array[i];
            count--;
        }
    }
    return result;
}

PrintArray(resultFirst);
PrintArray(resultSecond);
PrintArray(resultThird);