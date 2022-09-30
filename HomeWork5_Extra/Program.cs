int[] CreateArray()
{
    int[] array = new int [new Random().Next(2, 11)];
    return array;
}

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2);
        index ++;
    }
}

// Основная идея функции в том, что она возвращает несколько результатов в одном массиве.
// Эту идею удается использовать из-за однородности выходных данных.

int[] LongRow(int[] array)
{
    int[] result = new int [3];
    int len = 0;

    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] == array[i + 1])
        {
            len = 0;
            for (int j = i; j < array.Length - 1 && array[j] == array[j + 1]; j++)
            {
                len++;
            }
             
            if (len >= result[2]) 
            {
                result[0] = array[i]; // Повторяющееся значение
                result[1] = i; // Начальный индекс
                result[2] = len + 1; // Величина самой большой последовательности. В случае равенства длин хватается за первую длину.
            }
        }
    }
    
    return result;
}

int[] array = CreateArray();
FillArray(array);

int[] result = LongRow(array);

Console.WriteLine($"Массив {String.Join(", ", array)}");
Console.WriteLine();

Console.WriteLine($"Повторяющийся элемент {result[0]}");
Console.WriteLine();

Console.WriteLine($"Начальный индекс последовательности {result[1]}");
Console.WriteLine();

Console.WriteLine($"Количество повторений {result[2]}");
Console.WriteLine();