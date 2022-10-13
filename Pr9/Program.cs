/* Задача 70: Напишите программу, которая печатает последовательность чисел, где каждое 
следующее равно сумме двух предыдущих. На вход принимает 3 числа: n1, n2 и N, где n1 n2 - 
первые числа последовательности, N – длина последовательности	
3 и 4, N = 5 -> 3 4 7 11 18	6 и 10, N = 4 -> 6 10 16 26  */
 
/* Console.Clear();

int[] RowLikeFibo(int digit, int firstNum, int secondNum)
{
    int[] array = new int[digit];
    array[0] = firstNum;
    array[1] = secondNum;

    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }

    return array;
}

Console.Write("Введите первое число последовательности: ");
int numOne = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число последовательности: ");
int numTwo = int.Parse(Console.ReadLine()!);

Console.Write("Введите длину последовательности: ");
int numThree = int.Parse(Console.ReadLine()!);

int[] result = RowLikeFibo(numThree, numOne, numTwo);
Console.Write(string.Join(", ", result));
 */


/* В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
Покажите все слова, состоящие из 2 букв, которые можно построить из букв этого алфавита.
n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са,ав, ва, ви, ив, св, вс */
/* 
char[] alphabet = {'a', 'и', 'c', 'в'};

Console.Write("Сколько букв в слове? ");
int num = int.Parse(Console.ReadLine()!);

char[] word = new char[num];

WriteWord(alphabet, word);

void WriteWord(char[] array, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($" {new String(word) }");
        return;
    }

    for (int i = 0; i < array.Length; i++)
    {
        word[length] = array[i];
        WriteWord(array, word, length + 1);
    }
} */
/* 
int[] CreateArray()
{
    int[] result = new int[new Random().Next(1, 9)];
    return result;
}

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
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

int[] collection = CreateArray();
collection = FillArray(collection);
Console.WriteLine(String.Join(", ", collection));
int res = BinToDec(collection);
Console.WriteLine(res); */
/* 
int[] CreateArray()
{
    int[] result = new int[new Random().Next(1, 9)];
    return result;
}

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
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

int[] DataInfo(int[] firstArray, int[] secondArray)
{
    int[] result = new int[secondArray.Length];

    for(int i = 0; i < secondArray.Length; i++)
    {
        int counter = secondArray[i];

        for (int j = counter; j > -1; j-- )
        {
            result[]
        }
    }
} */
