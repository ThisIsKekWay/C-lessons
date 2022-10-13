/* Абсолютно бездарное решение, но работает.

Console.Write("Введите числа через запятую: ");
string[] array = Console.ReadLine()!.Split(", ");
Console.WriteLine($" [{String.Join(", ", array)}] ");
 */

// Решено как полагается.

int[] CreateArray()
{
    int[] array = new int [8];
    return array;
}

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next();
        index ++;
    }
}

int[] array = CreateArray();
FillArray(array);
Console.WriteLine(String.Join(", ", array));

