Console.Clear();


double[] Intersection(double[,] array)
{
    double[] result = new double[2];

    result[0] = Math.Round((array[1, 1] - array[0, 1]) / (array[0, 0] - array[1, 0]), 2);
    result[1] = Math.Round(array[0, 0] * result[0] + array[0, 1], 2);

    return result;
}

void PrintArray(double[,] arr)
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



void InputArray(double[,] array)
{
for (int i = 0; i < 2; i++)
{
    Console.Write($"Введите числовые коэффициенты уравнения {i + 1}");
    Console.WriteLine();
    for (int j = 0; j < 2; j++)
    {
        if(j == 0)
        {
            Console.WriteLine($"Введите k{i + 1}");
            array[i, j] = double.Parse(Console.ReadLine()!);
        }
        else
        {
            Console.WriteLine($"Введите b{i + 1}");
            array[i, j] = double.Parse(Console.ReadLine()!);
        }        
    }
}
}

double[,] array = new double [2, 2];
InputArray(array);
PrintArray(array);
double[] result = Intersection(array);
Console.WriteLine(String.Join("; ", result));