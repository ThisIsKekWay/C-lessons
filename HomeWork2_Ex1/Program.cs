// Вывести вторую цифру трехзначного числа

Console.Clear();

// Лекция была по функциям, всю домашку сделал с простейшими функциями

int Second(int number)
{
    int result = ((number / 10) % 10);
    return result;
}


Console.WriteLine("Введите число");
int num = Math.Abs(int.Parse(Console.ReadLine()));


if((num < 1000) & (num > 99))
{
    Console.WriteLine(Second(num));
}
else
{
    Console.WriteLine("Число не соответствует условию задачи"); 
}