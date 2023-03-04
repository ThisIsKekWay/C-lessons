void NumRow (int num)
{
    if (num != 0)
    {
        Console.Write($"{num}, ");
        NumRow(num - 1);
    }
}  

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

NumRow(number);

/* 
void NumRow (int num)
{
    while(num != 0)
    {
        Console.Write($"{num}, ");

        num --;
    }
    
}  


Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

NumRow(number); */