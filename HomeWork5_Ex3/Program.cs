double[] CreateArray()
{
    double[] array = new double [new Random().Next(2, 11)];
    return array;
}

void FillArray(double[] collection)
{
    int index = 0;
    while (index < collection.Length)
    {
        collection[index] = new Random().Next(-10000, 10001) * 0.001;
        collection[index] = Math.Round(collection[index], 2);
        index ++;
    }
}

double DifferenceMinMax(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }

    return Math.Round(max - min, 2); 
}

double[] array = CreateArray();
FillArray(array);

Console.WriteLine();
Console.WriteLine($"В массиве {String.Join(" | ", array)} разница между максимумом и минимумом равна {DifferenceMinMax(array)}");
