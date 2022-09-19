// Является ли цифра дня выходным. 1-е число всегда понедельник.
// Немного расширил задачу. По идее, она работает на любое число.
// Вручную проверил до 31 числа, совпадает с тем, что на бумаге.

bool IsWeekend(int number)
{
    if((number % 7 == 6) | (number % 7 == 0))
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Введите число");
int num = Math.Abs(int.Parse(Console.ReadLine()!));

if(IsWeekend(num) == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
