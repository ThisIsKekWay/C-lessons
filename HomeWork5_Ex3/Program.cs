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

// Решил не воевать с NextDouble из-за его сложности, поэтому заюзал целочисленную генерацию с последующим переносом запятой.
        collection[index] = Math.Round(new Random().Next(-10000, 10001) * 0.001, 2);
        index ++;
    }
}

// В прошлых версиях было вычисление разницы внутри метода, что противоречило вашей рекомендации
// "Один метод - одно действие"

double[] FindMinMax(double[] array)
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

    double[] result = {min, max};
    return result;
}

double[] array = CreateArray();
FillArray(array);
double[] result = FindMinMax(array);

double answer = Math.Round(result[1] - result[0], 2);

Console.WriteLine();
Console.WriteLine($"В массиве {String.Join(" | ", array)} разница между максимумом и минимумом равна {answer}");
