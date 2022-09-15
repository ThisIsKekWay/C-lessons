// Проверка числа на четность

Console.Clear();

Console.WriteLine("Введите число");
int Num = int.Parse(Console.ReadLine());

if(Num % 2 == 0)
    {
        Console.WriteLine("Число четное");
    }
else
    {
        Console.WriteLine("Число нечетное");
    }