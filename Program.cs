/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

Start();

void Start()
{
    while (true)
    {
        Console.WriteLine();
        Console.Write("Press enter: ");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
        Console.WriteLine();
        Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
        Console.WriteLine();
        Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. Например, даны 2 матрицы:");
        Console.WriteLine();
        Console.WriteLine("Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
        Console.WriteLine();
        Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. Например, на выходе получается вот такой массив:");
        Console.WriteLine();
        Console.WriteLine("0) End");

        int numTask = SetNumber("task");

        switch (numTask)
        {
            case 0: return;
            case 54: task54(); break;
            case 56: task56(); break;
            case 58: task58(); break;
            case 60: task60(); break;
            case 62: task62(); break;

            default: Console.WriteLine("error"); break;
        }
    }
}
//task54
void task54()
{
    void FillArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1, 20);
            }
        }
    }
    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j],5}");
            }
            Console.WriteLine();
        }
    }

    void SortRow(int[,] array1)
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                for (int k = 0; k < array1.GetLength(1) - j - 1; k++)
                {
                    if (array1[i, k] < array1[i, k + 1])
                    {
                        int b = array1[i, k];
                        array1[i, k] = array1[i, k + 1];
                        array1[i, k + 1] = b;
                    }
                }
            }
        }
    }

    int[,] array = new int[3, 4];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    SortRow(array);
    PrintArray(array);
    return;
}
//task56
void task56()
{
    void FillArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1, 10);
            }
        }
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j],5}");
            }
            Console.WriteLine();
        }
    }

    int Sum(int[,] array)
    {
        int sum = 0;
        int minSum = 0;
        int minNum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i == 0)
                {
                    sum += array[i, j];
                    minSum += array[i, j];
                }
                else sum += array[i, j];
            }
            if (sum < minSum)
            {
                minSum = sum;
                minNum = i;
            }
            sum = 0;
        }
        return minNum;
    }
    int[,] array = new int[3, 3];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine($"{Sum(array) + 1} строка c наименьшей суммой");
    return;
}
//task58
void task58()
{
    void FillArray(int[,] array1, int[,] array2)
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                array1[i, j] = new Random().Next(1, 10);
            }
        }
        for (int i = 0; i < array2.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                array2[i, j] = new Random().Next(1, 10);
            }
        }
    }

    void PrintArray(int[,] array1, int[,] array2)
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                Console.Write($"{array1[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < array2.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                Console.Write($"{array2[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    void Multiplication(int[,] array1, int[,] array2, int[,] mult)
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                mult[i, j] = array1[i, j] * array2[i, j];
            }
        }
    }

    void PrintMultArray(int[,] mult)
    {
        for (int i = 0; i < mult.GetLength(0); i++)
        {
            for (int j = 0; j < mult.GetLength(1); j++)
            {
                Console.Write($"{mult[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    int[,] array1 = new int[2, 2];
    int[,] array2 = new int[2, 2];
    int[,] mult = new int[2, 2];
    FillArray(array1, array2);
    PrintArray(array1, array2);
    Console.WriteLine();
    Multiplication(array1, array2, mult);
    PrintMultArray(mult);
    return;
}
//task60
void task60()
{
    void FillArray(int[,,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    array[i, j, k] = new Random().Next(10, 99);
                }

            }

        }
    }

    void PrintArray(int[,,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    Console.Write($"{array[i, j, k],3}({i}, {j}, {k})  ");
                }
                Console.WriteLine();

            }
        }
    }


    int[,,] array = new int[2, 2, 2];
    FillArray(array);
    PrintArray(array);
    return;
}
//task62
void task62()
{
    int a = 4;

    int[,] array = new int[a, a];
    int num = 1;
    int i = 0;
    int j = 0;
    while (num <= a * a)
    {
        array[i, j] = num;
        if (i <= j + 1 && i + j < a - 1)
            ++j;
        else if (i < j && i + j >= a - 1)
            ++i;
        else if (i >= j && i + j > a - 1)
            --j;
        else
            --i;
        num++;
    }
    for (i = 0; i < array.GetLength(0); i++)
    {
        for (j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],4}");
        }
        Console.WriteLine();
    }
    return;
}

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
