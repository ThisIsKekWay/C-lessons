/* Сумма положительных и отрицательных элементов массива. ДОДЕЛАТЬ!!

Console.Write("Введите числа через запятую: ");
string input = Console.ReadLine()!;
Console.Write("Введите числа через запятую: ");



int[] ParseToArray(string str)

{
    string[] stringArray = str.Split(" ");
    int[] result = new int[stringArray.Length];

    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = int.Parse(stringArray[i]);
    }

    return result;
}

int PositiveSum(int[] array)
int result
{
    for (int i = 0; i < array.Length; i++)
    {
        int result = 
    }
} */

/* 
int[] ParseToArray(string str)

{
    string[] stringArray = str.Split(" "); 
    int[] result = new int[stringArray.Length];

    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = int.Parse(stringArray[i]);
    }

    return result;
}

int[] SumOfArray(int[] firstArray, int[] secondArray)
{
    int[] result = new int [firstArray.Length];
    for (int i = 0; i < firstArray.Length; i++)
    {
        result[i] = firstArray[i] + secondArray[i];
    }

    return result;
}

Console.Write("Введите числа первого массива через пробел: ");
string firstArray = Console.ReadLine()!;

Console.Write("Введите числа второго массива через пробел: ");
string secondArray = Console.ReadLine()!;

int[] fArray = ParseToArray(firstArray);
int[] sArray = ParseToArray(secondArray);

if(fArray.Length != sArray.Length)
{
    Console.Write("Массивы неравноразмерны!!!!11!");
}
else
{
    int[] res = SumOfArray(fArray, sArray);
    Console.Write(String.Join(", ", res));
}
 */

/* 
int[] ParseToArray(string str1, string str2)

{
    string str = str1 + ' ' + str2;
    string[] stringArray = str.Split(" "); 
    int[] result = new int[stringArray.Length];

    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = int.Parse(stringArray[i]);
    }

    return result;
}

Console.Write("Введите числа первого массива через пробел: ");
string firstArray = Console.ReadLine()!;

Console.Write("Введите числа второго массива через пробел: ");
string secondArray = Console.ReadLine()!;

int[] newArray = ParseToArray(firstArray, secondArray);

Console.WriteLine(String.Join(", ", newArray)); */

int[] ParseToArray(string str)

{
    string[] stringArray = str.Split(" ");
    int[] result = new int[stringArray.Length];

    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = int.Parse(stringArray[i]);
    }

    return result;
}

int[] Reverse(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int c = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = c;
    }

    return array;
}

Console.Write("Введите элементы массива через пробел: ");
string array = Console.ReadLine()!;

int[] newArray = ParseToArray(array);
int[] newNewArray = Reverse(newArray);

Console.WriteLine(String.Join(", ", newNewArray));