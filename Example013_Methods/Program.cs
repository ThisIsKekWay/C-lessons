// Виды методов

// Метод 1. Войд-метод, который ничего не получает и ничего не возвращает.
// Не получает, потому что у него не прописаны его артибуты в скобках.
// Не возвращает, потому что нет оператора return. Все еще способны выводить данные на экран.
void Method1()
{
    Console.WriteLine("Автор программы дэбик");
}
Method1();

// Метод 2. Войд-метод, который уже что-то получает, но не возвращает ничего.
// Получает из-за прописанного аргумета метода. В данном случае это строковая переменная

void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2("Текст строки");

// При вызове метода можно конкретно обозначать за каким аргументом закрепить входные данные.
// Полезно при беспорядочном указании аргументов.

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i ++;
    }
}

Method21(count: 4, msg: "Новый текст");

// Метод 3. Методы, которые что-то возвращают. Но ничего не принимают.
// Обязательно надо указывать тип возвращаемых данных и оператор return.

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Метод 4. Методы, которые принимают и возвращают данные.

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result += text;
        i ++;
    }

    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res);
