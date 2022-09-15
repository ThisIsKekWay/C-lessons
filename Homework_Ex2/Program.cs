Console.Clear();

Console.WriteLine("Введите первое целое число");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int secondNum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье целое число");
int thirdNum = int.Parse(Console.ReadLine());

int max = firstNum;

if(secondNum > max) max = secondNum;
if(thirdNum > max) max = thirdNum;

Console.WriteLine("max = " + max);