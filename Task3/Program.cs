// Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.

Console.Clear();

int InputUser(string message)
{
    System.Console.Write($"{message}  => ");
    return Convert.ToInt32(Console.ReadLine());
}


int[,] CreationMatrix(int row, int col)  // создание массива
{
    int[,] array = new int[row, col];
    return array;
}

int[,] FillMatrix(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
    }
    Console.WriteLine();
}
void AveregeColumMatrix(int[,] array)
{
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            average += array[i, j];
        }
        System.Console.WriteLine($"в колонке {j + 1} = {Math.Round(average / array.GetLength(0), 1)}");
    }
}


try
{
    int userRows = InputUser("введите количество строк");
    int userCol = InputUser("введите количество столбцов");
    int[,] userMatrix = CreationMatrix(userRows, userCol);
    PrintMatrix(FillMatrix(userMatrix));
    System.Console.WriteLine($"среднее арифметическое значение в колонках: ");
    AveregeColumMatrix(userMatrix);

}

catch (FormatException)
{
    System.Console.WriteLine("вы ввели не число");
}
