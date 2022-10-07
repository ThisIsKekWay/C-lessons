// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

Console.Clear();
double[,] CreateArray(int rows, int coloumns)
{
    double[,] result = new double[rows, coloumns];
    return result;
}

double[,] FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().Next(0, 10001) * 0.001, 2);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
    
    Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int coloumns = int.Parse(Console.ReadLine()!);

double[,] nums = CreateArray(rows, coloumns);
nums = FillArray(nums);
PrintArray(nums);
