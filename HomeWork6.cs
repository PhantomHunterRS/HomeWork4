using System.Runtime.Intrinsics.X86;

internal class HomeWork6
    {
    // Task41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    public int[] inputNumbers()
    {
        Console.WriteLine("Enter real numbers separated by a space");
        int[] arrayLine = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
        return arrayLine;
    }
     public int countingPositiveNumbers(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                count++;
            }
        }
        return count;
    }

    // Task 43: Напишите программу, которая найдёт точку пересечения двух прямых,
    // заданных уравнениями y = k1* x + b1, y = k2* x + b2; значения b1, k1, b2 и k2 задаются пользователем.

    public int[] inputValues()
    {   int[] values = new int[4];
        bool cirle = true;
        while (cirle) {
            Console.WriteLine("Enter values b1, k1 to create a direct y = k1* x + b1 separated by a space");
            values = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            Console.WriteLine("Enter values b2, k2 to create a direct y = k2* x + b2 separated by a space");
            values = values.Concat(Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse)).ToArray();
            if (values[0] != values[2])
            {
                cirle = false;
            }
            else
            {
                Console.WriteLine("Straight lines don't intersect. they are parallel");
            }
        }
        return values;
    }
    public double[] findTheIntersectionPoint(int[] values)
    {
        double[] point = new double[2];
        point[0] = (values[3] - values[1]) / (double)(values[0] - values[2]);
        point[1] = (values[2] * ((values[3] - values[1]) / (double)(values[0] - values[2])) + values[2]);
        return point;
     }
}
