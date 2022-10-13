// Задача 1. Обратить знаки чисел в массиве.

/* void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-100, 101);
        index ++;
    }
    Console.WriteLine(String.Join(", ", collection));
}

void Reverse(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }

    Console.WriteLine(String.Join(", ", array));
}


int[] array = new int [10];
FillArray(array);
Reverse(array);
*/


// Задача 2. Искать число в массиве.
/* 



void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-10, 11);
        index ++;
    }
    Console.WriteLine(String.Join(", ", collection));
}

bool NumInArray(int[] array, int seek)
{
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] == seek)
       {
            return true;
       }
       else
       {
            return false;
       }
    }
    return false;
}

Console.WriteLine("Введите искомое число");
int num = int.Parse(Console.ReadLine()!);

int[] array = new int [10];
FillArray(array);
Console.WriteLine(NumInArray(array, num)); */



// Задача 3. Найти вхождение числа между 10 и 99
/*  
int[] CreateArray()
{
    int[] array = new int [123];
    return array;
}

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 201);
        index ++;
    }
}

int Count(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            result++;
        }
    }
    return result;
}

int[] array = CreateArray();
FillArray(array);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine(Count(array));
 */

/* int[] CreateArray()
{
    int[] array = new int [new Random().Next(10,12)];
    return array;
}

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 11);
        index ++;
    }
}

int[] Multiply(int[] array)
{
    int[] result;
    
    if (array.Length % 2 == 0)
    {
        result = new int [array.Length / 2];
    }
    else
    {
        result = new int [array.Length / 2 + 1];
    }
    for (int i = 0; i < result.Length; i++)
    {
        if (i == array.Length - 1 - i)
        {
            result[i] = array[i];
        }
        else
        {
            result[i] = array[i] * array[(array.Length - 1) - i];
        }
    }
    return result;
}


int[] array = CreateArray();
FillArray(array);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine();
Console.WriteLine(String.Join(", ", Multiply(array)));
 */