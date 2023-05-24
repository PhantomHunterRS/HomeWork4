using System;
using System.Collections;
using System.Runtime.Intrinsics.X86;

class HomeWork9
{
    //Task64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
    public int[] createArray64(int first, int second)
    {
        if (first < second)
            return new int[second - first + 1];
        else
            return new int[first - second + 1];
    }
    public void naturalNumbers(int[] array, int begin, int end, bool summ = false)
    { if (begin <= end)
        {
            array[array.Length - 1 - (end - begin)] = begin;
            begin++;
            naturalNumbers(array, begin, end);
        }
        else
            printOneDimensionalArray(array);
        if (summ) summNaturalNumbers(array);
    }
    public void printOneDimensionalArray(int[] arrayPrint)
    {
        for (int i = 0; i < arrayPrint.GetLength(0); i++)
        {
            Console.Write($"{arrayPrint[i]} \t");
        }
        Console.WriteLine();
    }

    public void summNaturalNumbers(int[] array)
    { int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        Console.WriteLine(sum);
    }

    //Task66: Задайте значения M и N.Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    public void naturalNumbers66(int[] array, int begin, int end, int summ = 0)
    {
        if (begin <= end)
        {
            summ += begin;
            array[array.Length - 1 - (end - begin)] = begin;
            begin++;
            naturalNumbers66(array, begin, end, summ);
        }
        else
            Console.WriteLine(summ);
    }

    //Task68: Напишите программу вычисления функции Аккермана с помощью рекурсии.Даны два неотрицательных числа m и n.
    public int ackermannFunction(int numberM, int numberN) { 
   
        if (numberM == 0) return numberN + 1;
        if (numberM != 0 && numberN == 0) return ackermannFunction(numberM - 1, 1);
        if (numberM > 0 && numberN > 0) return ackermannFunction(numberM - 1, ackermannFunction(numberM, numberN - 1));
        return ackermannFunction(numberM, numberN);   
   }
    public void ackermannFunctionStart(int numberM, int numberN)
    {
        Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {ackermannFunction(numberM, numberN)}");
    }
}
