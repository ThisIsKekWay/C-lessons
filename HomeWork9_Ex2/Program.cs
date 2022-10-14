int NumSum (int firstNum, int secondNum, int sum = 0)
{
    if (firstNum <= secondNum)
    {
        sum += firstNum;
        firstNum++;
        return NumSum(firstNum, secondNum, sum);
    }

    return sum;
}  

Console.Write("Введите первое число: ");
int numberOne = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int numberTwo = int.Parse(Console.ReadLine()!);

Console.Write(NumSum(numberOne, numberTwo));