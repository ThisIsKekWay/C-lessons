void NumRow (int num)
{
    /* for (int i = num; i > 0; i--)
    {
        Console.WriteLine(num);
        num--;
    } */

    if (num != 0)
    {
        Console.Write($"{num}, ");
        NumRow(num - 1);
    }
}  

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

NumRow(number);