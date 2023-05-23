using System;
using System.Collections;
using System.Runtime.Intrinsics.X86;

class HomeWork8
{
    //Task54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива
    public int[,] createTwoDimensionalArray(int first, int second)
    {
        return new int[first, second];
    }
    public int[,] fillingAValues(int[,] array, int quantity = 50)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(quantity);
            }
        }
        return array;
    }
    public void sortAllArray(int[,] array)
    {
        for (int k = 0; k < array.GetLength(0); k++)
        {
            for (int i = 0; i < array.GetLength(1); i++)
                for (int j = 0; j < array.GetLength(1) - i - 1; j++)
                {
                    if (array[k, j] > array[k, j + 1])
                    {
                        int temp = array[k, j];
                        array[k, j] = array[k, j + 1];
                        array[k, j + 1] = temp;
                    }
                }
        }
    }
    public void printTwoDimensionalArray(int[,] arrayPrint)
    {
        for (int i = 0; i < arrayPrint.GetLength(0); i++)
        {
            for (int j = 0; j < arrayPrint.GetLength(1); j++)
            {
                Console.Write($"{arrayPrint[i, j]} \t");
            }
            Console.WriteLine();
        }

    }
    public void printOneDimensionalArray(int[] arrayPrint)
    {
        for (int i = 0; i < arrayPrint.GetLength(0); i++)
        {
            Console.Write($"{arrayPrint[i]} \t");
        }
        Console.WriteLine();
    }


    //Task56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    public int[] amountValues(int[,] array)
    {
        int[] NewSummArray = new int[array.GetLength(0)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                NewSummArray[i] = NewSummArray[i] + array[i, j];
            }
        }
        return NewSummArray;
    }
    public void smallValue(int[] array)
    {
        int min = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[min]) min = i;
        }
        Console.WriteLine($"the smallest amount in a row - {min + 1} is equal to {array[min]}");
    }
    //Task58: Задайте две матрицы.Напишите программу, которая будет находить произведение двух матриц.
    public int[,] multiplicationMatrix(int[,] matrix1, int[,] matrix2)
    {
        int[,] newNatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
        for (int i = 0; i < newNatrix.GetLength(0); i++)
        {
            for (int j = 0; j < newNatrix.GetLength(1); j++)
            {
                for (int k = 0, g = 0; k < matrix1.GetLength(0) && g < matrix2.GetLength(1); k++, g++)
                {
                    newNatrix[i, j] = newNatrix[i, j] + matrix1[i, k] * matrix2[g, j];
                }
            }
        }
        return newNatrix;
    }
    //Task60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
    // которая будет построчно выводить массив, добавляя индексы каждого элемента.
    // Массив размером 2 x 2 x 2
    public int[,,] createThreeDimensionalArray(int first = 2, int second = 2, int third = 2)
    {
        return new int[first, second, third];
    }
    public int[,,] fillingThreeDimensionalArray(int[,,] array)
    {
        int numb = 10;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    array[i, j, k] = numb;
                    numb++;
                }

            }
        }
        return array;
    }
    public void printThreeDimensionalArray(int[,,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write($"[");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"[");
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    if (k == array.GetLength(2) - 1)
                    {
                        Console.Write($"{array[i, j, k]}({i},{j},{k})");
                    }
                    else
                    {
                        Console.Write($"{array[i, j, k]}({i},{j},{k}),");
                    }

                }
                Console.Write($"]");
            }
            Console.Write($"]");
        }
    }
    //Task62: Напишите программу, которая заполнит спирально массив 4 на 4.
    public int[,] fillingSpiral(int[,] array)
    {
        int s = 1;
        for (int y = 0; y < array.GetLength(0); y++)
        {
            array[0, y] = s;
            s++;
        }
        for (int x = 1; x < array.GetLength(1); x++)
        {
            array[x, array.GetLength(0) - 1] = s;
            s++;
        }
        for (int y = array.GetLength(0) - 2; y >= 0; y--)
        {
            array[array.GetLength(1) - 1, y] = s;
            s++;
        }
        for (int x = array.GetLength(1) - 2; x > 0; x--)
        {
            array[x, 0] = s;
            s++;
        }
        int c = 1;
        int d = 1;
        while (s < array.GetLength(1) * array.GetLength(0))
        {
            while (array[c, d + 1] == 0)
            {
                array[c, d] = s;
                s++;
                d++;
            }
            while (array[c + 1, d] == 0)
            {
                array[c, d] = s;
                s++;
                c++;
            }
            while (array[c, d - 1] == 0)
            {
                array[c, d] = s;
                s++;
                d--;
            }
            while (array[c - 1, d] == 0)
            {
                array[c, d] = s;
                s++;
                c--;
            }
        }
        for (int x = 0; x < array.GetLength(1); x++)
        {
            for (int y = 0; y < array.GetLength(0); y++)
            {
                if (array[x, y] == 0)
                {
                    array[x, y] = s;
                }
            }

        }
        return array;
    }
    public void printTwoDimensionalArray0(int[,] arrayPrint)
    {
        for (int i = 0; i < arrayPrint.GetLength(0); i++)
        {
            for (int j = 0; j < arrayPrint.GetLength(1); j++)
            {
                if (arrayPrint[i, j] / 10 == 0)
                {
                    Console.Write($"0{arrayPrint[i, j]} \t");
                }
                else
                {
                    Console.Write($"{arrayPrint[i, j]} \t");
                }
            }
            Console.WriteLine();
        }

    }

}
