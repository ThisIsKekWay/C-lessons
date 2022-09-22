Console.Clear();

int IsPalindrom(int number)
{
    string l = Convert.ToString(number);
    Console.WriteLine(l);
    int size = l.Length;
    Console.WriteLine(size);
    int[] array = new int[size];
    int index = 0;
    while (index < size)
    {
        array[index] = number % 10;
        number = number / 10;
        Console.WriteLine(String.Join(", ", array));
        index ++;
    }
    
    index = 0;
    int result = 0;
    int i = 0;
    while (index < size / 2)
    {
        if (array[index] == array[size - (i + 1)])
        {
            result ++;
        }    
        else
        {
            result = 0;
        }
        i ++;
        index ++;
    }
    return result;
}


Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine()!);

if (IsPalindrom(num) != 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}