Console.Clear();

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());


if(num > 0)
    {
        int count = 2;
        while(count <= num)
            {
                Console.Write($"{count} ");
                count += 2;
            }
    }
else
    {
        int count = -2;
        while(count >= num)
            {
                Console.Write($"{count} ");
                count -= 2;
            }
    }
