Console.Clear();

Console.WriteLine("Введите первое целое число");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int secondNum = int.Parse(Console.ReadLine());

Console.WriteLine($"{firstNum} в степени {secondNum} = {Math.Pow(firstNum, secondNum)}");
