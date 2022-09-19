Console.Clear();

int Third(int number)
{
    int count = 0;
    while(count < 2)
    {
        number = number / 10;
        count += 1;        
    }
    int result = number % 10;
    return result;
}


Console.WriteLine("Введите число");
int num = Math.Abs(int.Parse(Console.ReadLine()));

if(Third(num) == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(Third(num));
}
