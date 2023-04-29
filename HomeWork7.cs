

internal class HomeWork7
{
    //Task 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

    public int[,] createArray(int row, int cell)
    {
        return new int[row, cell];
    }
    public int[,] fillArray(int[,] array)
    {
        int[,] arr = array;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = new Random().Next(-100, 101);
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




}

