Console.Clear();

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

int count = -num;

while(count <= num)
    {
        Console.Write($"{count} ");
        count ++;
    }


/* Console.WriteLine("Введите число");
int Num = Math.Abs(int.Parse(Console.ReadLine()));


if((Num < 1000) & (Num > 99))
    {
        Console.WriteLine(Num % 10);
    }
else
    {
        Console.WriteLine("Число не соответствует условию задачи"); 
    }
 */