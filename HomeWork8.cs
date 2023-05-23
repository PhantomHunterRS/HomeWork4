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
    public int[,] fillingAValues(int[,] array,int quantity = 50)
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
                    if (array[k,j] > array[k,j + 1])
                    {
                        int temp = array[k,j];
                        array[k,j] = array[k,j + 1];
                        array[k,j + 1] = temp;
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
                    Console.Write($"{arrayPrint[i,j]} \t");
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


}
