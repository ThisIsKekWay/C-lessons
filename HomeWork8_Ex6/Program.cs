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

int[] FindMin(int[,] array)
{
    int[] indexOfMin = {0, 0};
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                indexOfMin[0] = i;
                indexOfMin[1] = j;
            }
        }
    }
    
    return indexOfMin;
}

int[,] MakeArrayGreatAgain(int[,] origArray, int[] col)
{
    int[,] newArray = new int[origArray.GetLength(0) - 1, origArray.GetLength(1) - 1];

    for (int i = 0, j = 0; i < origArray.GetLength(0); i++)
    {
        if (i == col[0]) continue;
        
        for (int k = 0, m = 0; k < origArray.GetLength(1); k++)
        {
            if (k == col[1]) continue;

            newArray[j, m] = origArray[i, k];
            m++;
        }
        j++;
    }
    return newArray;
}

int[,] collection = new int[new Random().Next(2, 6), new Random().Next(2, 6)];
FillArray(collection);
Console.WriteLine("В массиве ");
PrintArray(collection);
Console.WriteLine();
int[] minIndex = FindMin(collection);
Console.WriteLine($"Минимальное значение имеет элемент с индексами {String.Join(", ", minIndex)}");
int[,] greatArray = new int[collection.GetLength(0) - 1, collection.GetLength(1) - 1];
greatArray = MakeArrayGreatAgain(collection, minIndex);
PrintArray(greatArray);