// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();
int[,] CreateArray(int rows, int coloumns)
{
    int[,] result = new int[rows, coloumns];
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

void IsInArray(int[,] array, int seek)
{
    int answ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] == seek)
            {
                answ += 2;
                Console.WriteLine($"Совпадение на позиции {i + 1}, {j + 1}");
            }
            else
            {
                answ--;
            }
        }
    }
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int coloumns = int.Parse(Console.ReadLine()!);

Console.Write("Введите искомое число: ");
int seeking = int.Parse(Console.ReadLine()!);

int[,] nums = CreateArray(rows, coloumns);
nums = FillArray(nums);
PrintArray(nums);
IsInArray(nums, seeking);
