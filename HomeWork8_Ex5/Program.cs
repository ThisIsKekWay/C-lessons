// Идея в том, чтобы рекурсивно заставить "каретку" двигаться в четырех направлениях
void FillSpiral(int[,] matrix, int row = 0, int col = 0, int num = 1)
{
    if (((col > -1 && col < 4) && (row > -1 && row < 4)) && matrix[row, col] == 0)
    {
        matrix[row, col] = num;
        num++;

        if (col == 0 && row == 2) // Костыль, который призван убирать преждевременное срабатывание движения вправо
                                  // С позиции [0.2]  
        {
            FillSpiral(matrix, row - 1, col, num);
        }

        FillSpiral(matrix, row, col + 1, num); // Вправо
        FillSpiral(matrix, row + 1, col, num); // Вниз
        FillSpiral(matrix, row, col - 1, num); // Влево
        FillSpiral(matrix, row - 1, col, num); // Вверх
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }

        Console.WriteLine();
    }
}

int[,] collection = new int[4, 4];
                
FillSpiral(collection);
PrintArray(collection);
