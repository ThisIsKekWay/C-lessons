/* int num = new Random().Next(100, 1000);
Console.WriteLine("Число равно " + num);

int firstDigit = num / 100;
int lastDigit = num % 10;

Console.WriteLine(firstDigit * 10 + lastDigit);
*/

/*  
Console.WriteLine("Введите первое целое число");
int firstNum = Math.Abs(int.Parse(Console.ReadLine()));
Console.WriteLine("Введите второе целое число");
int secondNum = Math.Abs(int.Parse(Console.ReadLine()));

if(firstNum % secondNum == 0)
{
    Console.WriteLine("Числа кратны");
}
else
{
    Console.WriteLine("Числа не кратны, остаток от деления равен " + firstNum % secondNum);
}
 */





/* Console.WriteLine("Введите целое число");
int num = Math.Abs(int.Parse(Console.ReadLine()));

if((num % 7 == 0) & (num % 23 == 0))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
 */


Console.WriteLine("Введите первое целое число");
int firstNum = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе целое число");
int secondNum = int.Parse(Console.ReadLine()!);

if((Math.Pow(firstNum, 2) == secondNum) ^ (Math.Pow(secondNum, 2) == firstNum))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
