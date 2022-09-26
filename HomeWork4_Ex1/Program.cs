Console.Clear();

int Increase(int firstNum, int secondNum)
{
    int result = 1;
    for(int i = 0; i < secondNum; i++)
    {
        result *= firstNum;
    }
    return result;
}

Console.WriteLine("Введите первое целое число");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int secondNum = Math.Abs(int.Parse(Console.ReadLine()));

Console.WriteLine($"{firstNum} в степени {secondNum} = {Increase(firstNum, secondNum)}");
