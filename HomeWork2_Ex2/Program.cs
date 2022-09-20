// Вывести третью цифру числа с любой разрядностью.

Console.Clear();

int Third(int number)
{
    int count = 0;
    while(count < 2)
    {
        number = number / 10;
        count += 1;
    }
    
    int result = 0;

    if(number / 10 == 0)
    {
        result = -1;
    }
    else
    {
        result = number % 10;
    }
    return result;
}


Console.WriteLine("Введите число");
int num = Math.Abs(int.Parse(Console.ReadLine()!));

if(Third(num) == -1)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(Third(num));
}
