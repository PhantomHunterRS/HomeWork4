
    internal class HomeWork5
    {
    //Task 34 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    public int [] fillingTheArray() {
        return new int[]   {new Random().Next(100,999),
                            new Random().Next(100,999),
                            new Random().Next(100,999),
                            new Random().Next(100,999)};       
    }
    public int foundEvenNumbers(int [] array) {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]%2 == 0)
            {
                count++;
            }
        }
        return count;  
    }

    //Task 36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами
    public int[] fillingTheArray2()
    {
        return new int[]   {new Random().Next(-99,99),
                            new Random().Next(-99,99),
                            new Random().Next(-99,99),
                            new Random().Next(-99,99)};
    }

    public int summOfOddElements(int[] array)
    {
        int summ = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (i%2 != 0)
            {
                summ += array[i];
            }
        }
        return summ;
    }

    //Task38 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
    public double[] fillingTheArray3()
    {
        return new double [] {Math.Round((new Random().NextDouble()*2-1)*99,2),
                            Math.Round((new Random().NextDouble()*2-1)*99,2),
                            Math.Round((new Random().NextDouble()*2-1)*99,2),
                            Math.Round((new Random().NextDouble()*2-1)*99,2)};
    }
    public double findMinMaxRezult(double[] array)
    {
        return Math.Round((findMax(array) - findMin(array)),2);    
    }
    double findMin(double[] array)
    {
        double min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        Console.WriteLine("Min - " + min);
        return min;
    }
    double findMax(double[] array)
    {
        double max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        Console.WriteLine("Max - " + max);
        return max;
    }

}

