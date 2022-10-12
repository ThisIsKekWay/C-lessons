void FillArray(int[,] array)
{
    Random generator = new Random();

    for (int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(0, 6);
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

int[,] MultArray(int[,] firstArray, int[,] secondArray)
{
    int[,] result = new int[firstArray.GetLength(0), secondArray.GetLength(1)];

// Вот тут разогнал черную магию и заюзал вывод ошибки. Просто не знаю, что мне вывести в типе int[,]
// И void функцию не сделать потому что надо PrintArray() заставить выводить что-то. В общем, жду критики.
    if (firstArray.GetLength(1) != secondArray.GetLength(0)) throw new Exception("Такие матрицы нельзя перемножить"); 
        for (int i = 0; i < firstArray.GetLength(0); i++)
        {
            for (int j = 0; j < secondArray.GetLength(1); j++)
            {
                for (int k = 0; k < secondArray.GetLength(0); k++)
                {
                    result[i, j] += firstArray[i, k] * secondArray[k, j];
                }
            }
        }
    return result;
}

int[,] firstCollection = new int[new Random().Next(2, 3), new Random().Next(2, 4)];
FillArray(firstCollection);

int[,] secondCollection = new int[new Random().Next(2, 3), new Random().Next(2, 4)];
FillArray(secondCollection);

Console.WriteLine("Перемножаем массивы");

PrintArray(firstCollection);
Console.WriteLine();

Console.WriteLine("Умножаем на ");

PrintArray(secondCollection);
Console.WriteLine();

PrintArray(MultArray(firstCollection, secondCollection));

