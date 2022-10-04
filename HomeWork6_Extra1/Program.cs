Console.Clear();
// Вариант 1. Решение через математику. Идея в том, чтобы число приращивало разряд 
// к целому числу с каждым переходом в двоичную систему.

/* double DecToBin(int num, int remain = 0, int result = 0)
{
    if (num != 0)
    {
        remain = num % 2;
        num /= 2;
        return result + 10 * DecToBin(num) + remain;
    }
    else
    {
        return result;
    }
}

// Через числовые операции решать оказалось прикольно, однако при использовании int на преобразовании 1024 уходило в переполнение.
// Показывало какую-то дрянь. Поменял на double, пока работает.
Console.Write("Введите число для перевода в двоичную систему: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {number} в двоичной системе будет равно {DecToBin(number)}"); */


// Вариант 2. Решение через строки. Идея в том, чтобы приращивать двоичные разряды к строке, содержащей двоичное число.

string DecToBin(int num, int remain = 0, string result = "")
{
if (num > 0)
{
    remain = num % 2;
    num /= 2;
    return  DecToBin(num) + remain.ToString() + result;
}
else
{
    return result;
}    
}

Console.Write("Введите число для перевода в двоичную систему: ");
int number = int.Parse(Console.ReadLine()!);

// Этот вариант совсем не хотел дружить с введенным числом "0", поэтому проверку нуля поставил в теле программы.
if (number == 0)
{
    Console.WriteLine($"Число {number} в двоичной системе будет равно 0");
}
else
{
    string res = DecToBin(number);
    Console.WriteLine($"Число {number} в двоичной системе будет равно {res}");
}
