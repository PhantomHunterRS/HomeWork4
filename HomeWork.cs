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

        // HomeWork 8
        // Task 54
        //HomeWork8 hw8 = new HomeWork8();
        //int[,] newArray8 = hw8.createTwoDimensionalArray(6, 5);
        //hw8.fillingAValues(newArray8, 15);
        //Console.WriteLine("New Array");
        //hw8.printTwoDimensionalArray(newArray8);
        //hw8.sortAllArray(newArray8);
        //Console.WriteLine("New Array sorting");
        //hw8.printTwoDimensionalArray(newArray8);
        //// Task 56
        //hw8.smallValue(hw8.amountValues(newArray8));
        //// Task 58
        //int[,] newArrayMatrix1 = hw8.createTwoDimensionalArray(2, 2);
        //int[,] newArrayMatrix2 = hw8.createTwoDimensionalArray(2, 2);
        //hw8.fillingAValues(newArrayMatrix1, 10);
        //hw8.fillingAValues(newArrayMatrix2, 10);
        //hw8.printTwoDimensionalArray(hw8.multiplicationMatrix(newArrayMatrix1, newArrayMatrix2));
        //// Task 60
        //int[,,] newArray3T = hw8.createThreeDimensionalArray();
        //hw8.printThreeDimensionalArray(hw8.fillingThreeDimensionalArray(newArray3T));
        //// Task 62
        //int[,] newArray62 = hw8.createTwoDimensionalArray(4, 4);
        //hw8.printTwoDimensionalArray0(hw8.fillingSpiral(newArray62));

        // HomeWork 9
        HomeWork9 hw9 = new HomeWork9();
        //Task64 если написать false (или ничего не писать) то будет 64 задача, написать True будет и 66
        Console.WriteLine("enter the starting number");
        int numberBegin = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the ending number");
        int numberEnd = int.Parse(Console.ReadLine());
        int[] newArray64 = hw9.createArray64(numberBegin, numberEnd);
        if (numberBegin < numberEnd)
        {
            hw9.naturalNumbers(newArray64, numberBegin, numberEnd, false);
        }
        else
        {
            hw9.naturalNumbers(newArray64, numberEnd, numberBegin, false);
        }

        //Task66
        if (numberBegin < numberEnd)
        {
            hw9.naturalNumbers66(newArray64, numberBegin, numberEnd);
        }
        else
        {
            hw9.naturalNumbers66(newArray64, numberEnd, numberBegin);
        }
        //Task68
        hw9.ackermannFunctionStart(numberBegin,numberEnd);

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

