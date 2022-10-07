Console.Clear();
int[,] CreateArray()
{
    int[,] result = new int[new Random().Next(2, 6), new Random().Next(2, 6)];
    return result;
}

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-5, 6);
        }
    }
    return array;
}

double[] ColoumnsMean(int[,] array)
{
    double[] res = new double[array.GetLength(1)];
    double summ = 0;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            summ += array[j, i];
        }
        res[i] = Math.Round(summ / array.GetLength(0), 2);
        summ = 0;
    }

    return res;
}

void PrintArray(int[,] array)
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

int[,] nums = CreateArray();
nums = FillArray(nums);

double[] col = ColoumnsMean(nums);

Console.WriteLine("В массиве");
Console.WriteLine();
PrintArray(nums);
Console.WriteLine();
Console.WriteLine($"Среднее арифметическое в каждом столбце равно {String.Join(", ", col)}");