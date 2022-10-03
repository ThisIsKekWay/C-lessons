int[] CreateArray(int num)
{
    int[] array = new int [num];
    return array;
}

int[] StringToArray(string[] array)
{
    int[] result = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        result[i] = int.Parse(array[i]);
    }

    return result;
}

int MoreThanZero(int[] array, int index = 0, int counter = 0)
{
    if (index < array.Length)
    {
        if (array[index] > 0)
        {
            return MoreThanZero(array, ++index, ++counter);
        }
        else
        {
            return MoreThanZero(array, ++index, counter);
        }
    }

    return counter;
}

Console.WriteLine("Введите размерность");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Введите числа через запятую. Надо {num}");
string[] array = Console.ReadLine()!.Split(",");

int[] collection = CreateArray(num);
collection = StringToArray(array);
int result = MoreThanZero(collection);

Console.WriteLine($"В массиве {String.Join(", ", array)} колличество чисел больше нуля равно {result}");