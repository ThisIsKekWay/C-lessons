void AllTripple(int number)
{
    int count = 0;
    if (number < 0)
    {
        count = -1;
        while (count > number - 1)
        {
            Console.Write(Math.Pow(count, 3));
            if (count != number)
            {
                Console.Write(", ");
            }  
            count --;
        }
    }
    else
    {
        count = 1;
        while (count < number + 1)
        {
            Console.Write(Math.Pow(count, 3));
            if (count != number)
            {
                Console.Write(", ");
            }  
            count ++;
        }
    }
}        
        

Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine()!);

AllTripple(num);