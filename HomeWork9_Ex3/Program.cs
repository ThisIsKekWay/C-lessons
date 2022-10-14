﻿int Ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m != 0) && (n == 0))
    {
        return Ackerman(m - 1, 1);
    }
    else return Ackerman(m - 1, Ackerman(m, n - 1));

}

Console.Write("Введите m: ");
int firstNum = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int secondNum = int.Parse(Console.ReadLine()!);

Console.WriteLine(Ackerman(firstNum, secondNum));