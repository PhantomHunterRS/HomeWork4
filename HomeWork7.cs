

using System;

internal class HomeWork7
{
    //Task 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

    public int[,] createArray(int row, int cell)
    {
        return new int[row, cell];
    }
    public int[,] fillArray(int[,] array,int minValue = -100, int maxValue= 101)
    {
        int[,] arr = array;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = new Random().Next(minValue, maxValue);
            }
        }
        return arr;
    }
    public void printTwoArray(int[,] arrayPrint)
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
    //Task 50 Напишите программу, которая на вход принимает позиции 
    //элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет
    public void foundNumberUser(int numberUser,int[,] array)
    {
        bool found = false;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
             if (array[i,j] == numberUser)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($" Your number - {numberUser} - is found in a two-dimensional array [{i+1},{j+1}]");
                    found = true;
                }
            }       
        }
        if (!found)           
            {Console.WriteLine($" Your number is not found"); }
    }
    //Task 52. Задайте двумерный массив из целых чисел.Найдите среднее арифметическое элементов в каждом столбце.
    public void arithmeticMean(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            double arithmet = 0.0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                arithmet = arithmet + array[i,j];
                Console.WriteLine($"{arithmet}");
            }
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"The arithmetic mean is equal to the string - {Math.Round(arithmet/ array.GetLength(1),2)}");
        }
    }

}


