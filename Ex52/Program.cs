// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void Zadacha52()
{
    Console.Clear();
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];
    double[] average = new double[columns];
    Console.WriteLine($"Массив размера {rows} x {columns}");
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine("Среднее арифметическое элементов столбцов: ");
    PrintArraySingle(ArrayAverage(array));

    double[] ArrayAverage(int[,] array)
    {
        double[] average = new double[array.GetLength(1)];
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, j];
            }
            average[j] = Math.Round(sum / array.GetLength(0), 2);
        }
        return average;

    }
   
    void PrintArraySingle(double[] average)
    {
        for (int i = 0; i < average.Length; i++)
        {
            Console.Write(average[i] + "\t");
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


Zadacha52();

