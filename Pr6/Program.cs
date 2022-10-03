/* Console.Clear();

int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Sum: {RecSum(number)}");

int RecSum(int number)
{
    if (number > 1)
    {
        return number + RecSum(--number);
    }
    else
    {
        return 1;
    }
} */

/* Console.Write($"Введите число: ");

int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"В числе {num} число знаков равно {CountDigits(num)}");

int CountDigits(int number, int counter = 1)
{

    if (number / 10 == 0) 
    {
        return counter;
    }
    else
    {
        return counter + CountDigits(number / 10);
    }

} */
 
/* int[] array = new int[5];
PrintArray(array);

void PrintArray(int[] array, int index = 0)
{
    if (index < array.Length)
    {
        Console.Write($"{array[index]} ");
        index++;
        PrintArray(array, index);

    }
}  */

int[,] CreateArray(int row, int coloumn)
{
    int[,] array = new int [row, coloumn];
    return array;
}

void FillArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i,j] = new Random().Next(0, 2);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int rows = 0; rows < arr.GetLength(0); rows++)
    {
        for(int coloumns = 0; coloumns < arr.GetLength(1); coloumns++)
        {
            Console.Write($"| {arr[rows, coloumns]} |");
        }
    Console.WriteLine();
    }
}

Console.Write("Введите число строк: ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов: ");
int coloumn = int.Parse(Console.ReadLine()!);

int[,] ar = CreateArray(row, coloumn);
FillArray(ar);
PrintArray(ar);
