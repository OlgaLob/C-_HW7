void Zadacha50()
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
{
    Console.Clear();
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];
    Console.WriteLine($"Массив размера {rows} x {columns}");
    FillArray(array);
    PrintArray(array);

    Console.Write("Введите индекс строки: ");
    int row = int.Parse(Console.ReadLine()!);
    Console.Write("Введите индекс столбца: ");
    int column = int.Parse(Console.ReadLine()!);
    FindPozition(array, row, column);
    if (FindPozition(array, row, column))
    {
        Console.WriteLine(array[row, column]);
    }
    else
    {
        Console.WriteLine("Такого элемента не существует");
    }

    bool FindPozition(int[,] array, int row, int column)
    {

        if (row < array.GetLength(0) && column < array.GetLength(1) && row >= 0 && column >= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");

        }
        Console.WriteLine();
    }
}

void FillArray(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(0, 10);
        }
    }
}


Zadacha50();
