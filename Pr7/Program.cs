// Создать и заполнить трехмерный массив с заданными координатами числами от 0 до 99.

/* Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write("Введите число рядов: ");
int z = int.Parse(Console.ReadLine()!);

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

void PrintArray(int[,,] array)
{
    for (int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}

int[,,] array = new int[m, n, z];
FillArray(array);
PrintArray(array); */
/* 
Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

void FillArray(int[,] array)
{
    for (int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
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
} */
/* 
int[,] Multiply(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] = array[i, j] * array[i, j];
            }
        }
    }

    return array;
}

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

int[,] array = new int[new Random().Next(2, 6), new Random().Next(2, 6)];
FillArray(array);
PrintArray(array);
Console.WriteLine();
array = Multiply(array);
PrintArray(array); */
/* 
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

int MainDiagSumm(int[,] array)
{
    int result = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                result += array[i, j];
            }            
        }
    }

    return result;
}

int[,] array = new int[new Random().Next(2, 6), new Random().Next(2, 6)];
FillArray(array);
Console.WriteLine("В массиве ");
PrintArray(array);
Console.WriteLine($"Сумма чисел главной диагонали равна: {MainDiagSumm(array)}"); */

