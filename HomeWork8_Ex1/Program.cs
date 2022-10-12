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

// Буду признателен, если предложите рекомендации, как избежать такого большого количества вложенных циклов
void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for ( int k = 0; k < array.GetLength(1); k++)
            {
                if (array[i, j] <= array[i, k]) continue;
                int buffer = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = buffer;
            }
        }
    }
}

int[,] col = CreateArray();
col = FillArray(col);
PrintArray(col);
SortArray(col);
Console.WriteLine();
PrintArray(col);
