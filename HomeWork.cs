using System;

internal class HomeWork
{
    private static void Main(string[] args)
    {
        HomeWork x = new HomeWork();

        //Task 25
        Console.WriteLine("Input two numbers.the first number to be raised, the second number to what degree.separated by commas");
        int[] inputNumbers = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
        Console.WriteLine(x.mathPows(inputNumbers[0], inputNumbers[1]));
        //Task27
        Console.WriteLine("Input a number to calculate the amount");
        string number = Console.ReadLine();
        Console.WriteLine(x.summNumbers(number));
        //Task29
        Console.WriteLine("Input a 8 numbers separated by commas");
        string numberStr = Console.ReadLine();
        int [] arrNumbers = x.arrayNumbers(numberStr);
        x.arrNumb(arrNumbers);

    }

    //Task25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
    int mathPows(int a, int b)
    { int mathPow = a, count = 1;
        while (count < b)
        {
            mathPow *= a; count++;
        }
        return mathPow;
    }
    //Task27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
    int summNumbers(string number)
    { int summNumbers = 0;
        for (int i = 0; i < number.Length; i++)
        {
            summNumbers += Convert.ToInt32(number[i].ToString());
        }
        return summNumbers;
    }
    //Task29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
    int [] arrayNumbers(string numbers){
        string[] arrNumbers = numbers.Split(",");
        int [] arrayNumbs = new int[arrNumbers.Length];       
        for (int i = 0; i < arrNumbers.Length; i++)
        {
            arrayNumbs[i] = Convert.ToInt32(arrNumbers[i].ToString());
        }
        return arrayNumbs;
    }
    void arrNumb(int[] arr)
    {
        string arrString = "[";
        for (int i = 0;i < arr.Length; i++)
        {
            if (i == arr.Length - 1)
            {
                arrString = arrString + "," + arr[i] + "]";
            }
            else if (i == 0)
            {
                arrString = arrString + arr[i];
            }

            else
            {
                arrString = arrString + "," + arr[i];
            }
        }
        Console.WriteLine(arrString);
    }
}

