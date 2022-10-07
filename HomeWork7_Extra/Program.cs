int [] FindNFibonachiNums(int nums)
{
    int[] result;
    if (nums < 2)
    {
        result = new int[1];
        result[0] = 0;
        return result;
    }
    else
    {
        result = new int[nums];
        result[0] = 0;
        result[1] = 1;
        for (int index = 2; index < result.Length; index++)
        {
            result[index] = result[index - 1] + result[index - 2];
        } 
        return result;
    }
}

Console.WriteLine("Введите сколько чисел вывести на экран");
int numberOf = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Обожаю числа Фибоначи. Вот они слева направо: {String.Join(", ", FindNFibonachiNums(numberOf))}");
