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
        collection[index] = new Random().Next(100, 1000);
        index ++;
    }
}

// Попытался сделать две функции. Одна на поиск минимума и максимума,
// а вторая на подсчет разницы. Но пока что не умею выводить из функции два результата разом.
// Нашел примеры, однако мне они не понравились. Поэтому пришлось нарушить вашу рекомендацию
// "Одна функция - одно действие".

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

    return max - min; 
}

double[] array = CreateArray();
FillArray(array);

Console.WriteLine($"В массиве {String.Join(", ", array)} разница между максимумом и минимумом равна {DifferenceMinMax(array)}");
