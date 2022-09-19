int[] array = {71, 62, 43, 14, 95, 86, 57, 38, 29};

int n = array.Length;
int find = 95;

int index = 0;
while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index ++;
}