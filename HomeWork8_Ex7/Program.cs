Console.Clear();

Console.Write("Введите номер строки: ");
int num = int.Parse(Console.ReadLine()!);
Pascal(num);

void Pascal(int num)
{
    for (int i = 0; i < num; i++)
    {
        int count = 1;
        for (int j = 0; j < num - i; j++)
        {
            Console.Write("   ");
        }
 
        for (int x = 0; x <= i; x++)
        {
            Console.Write("    {0:D} ", count);
            count = count * (i - x) / (x + 1);
        }
        
        Console.WriteLine();
        Console.WriteLine();
    }

    Console.WriteLine();
}