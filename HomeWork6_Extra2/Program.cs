double ArMean(double sum = 0, int counter = 0)
{
    double num = double.Parse(Console.ReadLine()!);
    sum += num;
    if (num != -1)
    {
        counter++;
        return ArMean(sum, counter);
    }
    return (sum + 1) / counter;
}

double res = Math.Round(ArMean(), 2);
Console.WriteLine(res);

