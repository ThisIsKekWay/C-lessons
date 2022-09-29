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
        collection[index] = new Random().Next(-100, 101);
        index ++;
    }
}

int SumOnOddPosition(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        result += array[i];
    }

    return result;
}

int[] array = CreateArray();
FillArray(array);

Console.WriteLine($"Сумма элементов на нечетных позициях в массиве {String.Join(", ", array)} равна {SumOnOddPosition(array)}");
