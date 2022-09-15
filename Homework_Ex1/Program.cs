// Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();

Console.WriteLine("Введите первое целое число");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int secondNum = int.Parse(Console.ReadLine());

if(firstNum > secondNum)
    {
        Console.WriteLine("Первое число больше второго");
    }

else
    {
        Console.WriteLine("Второе число больше первого");
    }