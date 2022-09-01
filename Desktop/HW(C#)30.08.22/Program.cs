// // Задача 54
// // Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.


Console.Clear();
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
Console.Write("Input strings count: ");
int stringsCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns count: ");
int columnsCount = Convert.ToInt32(Console.ReadLine());
int[,] newArray = CreateArray(stringsCount, columnsCount);
ShowOriginArray(newArray);
Console.WriteLine();
ShowSortArray(SortArray(newArray));


// // Задача 56
// // Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


Console.Clear();
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
Console.Write("Input sting count: ");
int stringCounts = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns count: ");
int columnsCounts = Convert.ToInt32(Console.ReadLine());
while (stringCounts == columnsCounts)
{
    Console.WriteLine("Error, the array must be rectangular!");
    Console.Write("Input sting count: ");
    stringCounts = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns count: ");
    columnsCounts = Convert.ToInt32(Console.ReadLine());
}
int[,] array = CreateArra(stringCounts, columnsCounts);
PrintArra(array);
Console.WriteLine();
PrintSum(SumInString(array));
Console.WriteLine();
Console.WriteLine($"Minimum amount in line {MinSumInString(SumInString(array))}");


// Задача 58
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


Console.Clear();
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

int[,] resultMatrix = new int[m,p];

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
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
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

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}


// Задача 60
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


Console.Clear();
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

void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
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


// Задача 62
// Заполните спирально массив 4 на 4.


Console.Clear();
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
