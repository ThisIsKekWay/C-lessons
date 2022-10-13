Random generator = new Random();

int[] CreateData()
{
    int[] result = new int[generator.Next(10, 16)];
    return result;
}

int[] FillData(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = generator.Next(0, 2);
    }
    return array;
}

int[] CreateInfo()
{
    int[] result = new int[4];
    return result;
}

int[] FillInfo(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = generator.Next(num/2 + 1);
        num -= array[i];
    }
    return array;
}

int BinToDec(int[] array)
{
    int result = 0;
    int count = 0;

    for(int i = array.Length - 1; i > -1; i--)
    {
        result += array[i] * (int)Math.Pow(2, count);
        count++;
    }

    return result;
}

int[] DataDiv(int[] dat, int[] inf)
{
    int index = 0;
    int[] result = new int[inf.Length];

    for (int i = 0; i < inf.Length; i++)
    {
        int[] buffer = new int[inf[i]];
                      
        for (int j = 0; j < inf[i]; j++)
        {
            buffer[j] = dat[index];
            index++;
        }

        Console.WriteLine($"Массив №{i}: {String.Join(", ", buffer)}");
        result[i] = BinToDec(buffer);
    }

    return result;
}

int[] data = CreateData();
data = FillData(data);
Console.WriteLine($"Числа в двоичном виде: {String.Join(", ", data)}");

int[] info = CreateInfo();
info = FillInfo(info, data.Length);
Console.WriteLine($"Раделители: {String.Join(", ", info)}");

Console.WriteLine($"Итоговый массив десятичных чисел: {String.Join(", ", DataDiv(data, info))}");