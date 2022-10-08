// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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
            array[i, j] = new Random().Next(-10, 11);
        }
   }

   return array;
}

int IsInArray(int[,] array, int rows, int coloumns)
{
    if( rows <= 0 || coloumns <= 0)
    {
        return -1;
    }
    else if (rows - 1 < array.GetLength(0) ^ coloumns - 1 < array.GetLength(1))
    {
        return -1;
    }
    else
    {
        return array[rows - 1, coloumns -1];
    }
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

int[,] collection = CreateArray();

collection = FillArray(collection);

PrintArray(collection);

Console.Write("Введите координату Х: ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Y: ");
int coloumn = int.Parse(Console.ReadLine()!);

if (IsInArray(collection, row, coloumn) == -1)
{
    Console.WriteLine($"По введенным координатам ничего нет, либо данные не корректны");
}
else
{
    Console.WriteLine($"По введенным координатам [{row}, {coloumn}] хранится число {IsInArray(collection, row, coloumn)}");
}