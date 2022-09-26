Console.Clear();

int SumOfDigits(int number)
{
    string l = Convert.ToString(number);
    int[] array = new int[l.Length];
    int sum = 0;
    for (int i = 0; i < l.Length; i++)
    {
        array[i] = number % 10;
        number = number / 10;
        sum = sum + array[i];
    }
    return sum;
}

Console.Write("Введите число ");
int num = Math.Abs(int.Parse(Console.ReadLine()!));
Console.Write(SumOfDigits(num));
