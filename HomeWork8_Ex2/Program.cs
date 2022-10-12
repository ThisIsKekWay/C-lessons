Console.Clear();

void FillArray(int[,] array)
{
    Random generator = new Random();

    for (int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(0, 11);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }

        Console.WriteLine();
    }
}

int SumInARow(int[,] array)
{
    int[] temp = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp[i] = temp[i] + array[i, j];
        }
    }

    return Array.IndexOf(temp, temp.Max()) + 1;
}

int[,] array = new int[new Random().Next(4, 6), new Random().Next(2, 4)];
FillArray(array);
Console.WriteLine("В массиве");
PrintArray(array);
Console.WriteLine($"Строка с самой большой суммой элементов под номером: {SumInARow(array)}");