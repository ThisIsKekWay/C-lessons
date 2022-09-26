/* string Method4(int count, string text)
{
    string result = String.Empty;
    for( int i = 0; i < count; i++)
    {
        result += text;
    }

    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res);*/

/* for( int i = 2; i <= 10; i++)
{
    for(int j = 0; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
 */

 // Дан текст. Требуется заменить все пробелы в нем черточками,
 // маленькие "к" на большие и большие "с" на маленькие.


/* string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "еже ли вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] = r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }   
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);

newText = Replace(text, 'С', 'с');
Console.WriteLine(newText); */

// Сортировка массива методом выбора.

int[] array = {1, 5, 4, 6, 5, 7, 9, 14, 15, 2};

void PrintArray(int[] arr)
{
    int count = arr.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();

}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1 ; i++)
    {
        int minPosiiton = i;
        
        for(int j = i + 1; j < array.Length ; j++)
        {
            if(array[j] < array[minPosiiton]) minPosiiton = j;
        }
        int temporary = array[i];
        array[i] = array[minPosiiton];
        array[minPosiiton] = temporary;
    }
}

PrintArray(array);
SelectionSort(array);
PrintArray(array);