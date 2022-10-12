void PrintArray(int[,,] array)
{
    for (int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}

void FillArray(int[,,] array)
{
    Random generator = new Random();

    for (int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = generator.Next(0, 100);
            }
        }
    }
}

int[,,] collection = new int[new Random().Next(2, 4),new Random().Next(2, 4),new Random().Next(2, 4)];
FillArray(collection);
PrintArray(collection);