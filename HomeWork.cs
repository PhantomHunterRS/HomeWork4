using System.Threading.Tasks;

internal class HomeWork
{
    private static void Main(string[] args)
    {
        HomeWork x = new HomeWork();
        ////Task 25
        //Console.WriteLine("Input two numbers.the first number to be raised, the second number to what degree.separated by commas");
        //int[] inputNumbers = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
        //Console.WriteLine(x.mathPows(inputNumbers[0], inputNumbers[1]));
        ////Task27
        //Console.WriteLine("Input a number to calculate the amount");
        //string number = Console.ReadLine();
        //Console.WriteLine(x.summNumbers(number));
        ////Task29
        //Console.WriteLine("Input a 8 numbers separated by commas");
        //string numberStr = Console.ReadLine();
        //int[] arrNumbers = x.arrayNumbers(numberStr);
        //x.arrNumb(arrNumbers);

        //// Домашнее задание 5
        //HomeWork5 y = new HomeWork5();
        ////Task34
        //int[] ints34 = y.fillingTheArray();
        //x.arrNumb(ints34);
        //Console.WriteLine(y.foundEvenNumbers(ints34));
        ////Task36
        //int[] ints36 = y.fillingTheArray2();
        //x.arrNumb(ints36);
        //Console.WriteLine(y.summOfOddElements(ints36));
        ////Task38
        //double[] ints38 = y.fillingTheArray3();
        //x.arrNumb(ints38);
        //Console.WriteLine(y.findMinMaxRezult(ints38));

        //// Домашнее задание 6
        //HomeWork6 hw6 = new HomeWork6();
        //// Task41
        //Console.WriteLine(hw6.countingPositiveNumbers(hw6.inputNumbers()));
        //// Task 43
        //x.arrNumb(hw6.findTheIntersectionPoint(hw6.inputValues()));

        // HomeWork 7
        // Task47
        //HomeWork7 hw7 = new HomeWork7();
        //int[,] inits47 = hw7.fillArray(hw7.createArray(10, 10));
        //hw7.printTwoArray(inits47);
        //// Task 50. 
        //Console.WriteLine("Enter the number you need to find in the array");
        //int inputNumber = Int32.Parse(Console.ReadLine());
        //hw7.foundNumberUser(inputNumber, inits47);
        //// Task 52. 
        //int[,] inits52 = hw7.fillArray(hw7.createArray(4, 7),0,30);
        //hw7.printTwoArray(inits52);
        //hw7.arithmeticMean(inits52);


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
    void arrNumb(double[] arr)
    {
        string arrString = "[";
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == arr.Length - 1)
            {
                arrString = arrString + ";" + arr[i] + "]";
            }
            else if (i == 0)
            {
                arrString = arrString + arr[i];
            }

            else
            {
                arrString = arrString + ";" + arr[i];
            }
        }
        Console.WriteLine(arrString);
    }
}

