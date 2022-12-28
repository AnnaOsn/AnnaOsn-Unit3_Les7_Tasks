// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами от -10,0 до 10,0.

// m = 3, n = 4.

// 0,5 7,0 -2,0 -0,2

// 1,0 -3,3 8,0 -9,9

// 8,0 7,8 -7,1 9,0

Console.WriteLine("enter m");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter n");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine(" ");
    }}