// Проверить, является ли пятизначное число палиндромом

Console.Clear();

bool IsPalindrom(int number)
{
    int[] array = new int[5];
    int index = 0;
    while (index < 5)
    {
        array[index] = number % 10;
        number = number / 10;
        index ++;
    }

    if (array[0] == array[4] & array[1] == array[3])
    {
        return true;
    }    
    else
    {
        return false;
    }
}


Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine()!);

if (num / 100000 != 0)
{
    Console.WriteLine("Введено некорректное число");
}
else
{
    if (IsPalindrom(num) == true)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}