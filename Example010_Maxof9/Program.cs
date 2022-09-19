Console.Clear();

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 15, a2 = 12, a3 = 13,
    b1 = 21, b2 = 23, b3 = 2015,
    c1 = 39, c2 = 33, c3 = 33;

/* int max1 = Max(a1, a2, a3);
int max2 = Max(b1, b2, b3);
int max3 = Max(c1, c2, c3); */
int max = Max(
    Max(a1, a2, a3), 
    Max(b1, b2, b3), 
    Max(c1, c2, c3));

Console.WriteLine(max);
