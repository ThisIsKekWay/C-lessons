Console.Write("Введите числа через запятую: ");
string[] array = Console.ReadLine()!.Split(", ");
Console.WriteLine($" [{String.Join(", ", array)}] ");

