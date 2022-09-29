// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

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
        collection[index] = new Random().Next(-500, 501);
        index ++;
    }
}

int CountOdd(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result++;
    }
    return result;
}

int[] array = CreateArray();
FillArray(array);

Console.WriteLine($"В массиве {String.Join(", ", array)} число четных элементов равно {CountOdd(array)}");

