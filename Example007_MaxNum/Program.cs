Console.WriteLine("Введите первое целое число");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число");
int thirdNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите четвертое целое число");
int fourthNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите пятое целое число");
int fifthNum = Convert.ToInt32(Console.ReadLine());

int max = firstNum;

if(secondNum > max) max = secondNum;
if(thirdNum > max) max = thirdNum;
if(fourthNum > max) max = fourthNum;
if(fifthNum > max) max = fifthNum;

Console.WriteLine("max = " + max);
