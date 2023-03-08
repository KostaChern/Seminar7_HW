// Задача 2. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

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

int SearchElementPosition(int[,] array, int row, int col)
{
    return array[row, col];
}

try
{
    int userRows = InputUser("введите количество строк");
    int userCol = InputUser("введите количество столбцов");
    int[,] userMatrix = CreationMatrix(userRows, userCol);
    PrintMatrix(FillMatrix(userMatrix));
    int searchRow = InputUser("введите идекс строки");
    int searchCol = InputUser("введите индекс столбца");
    System.Console.WriteLine($"элемент массива  {searchRow+1} строки и {searchCol+1} столбца = {SearchElementPosition(userMatrix, searchRow, searchCol)}");

}

catch (FormatException)
{
    System.Console.WriteLine("вы ввели не число");
}
catch (IndexOutOfRangeException)
{
    System.Console.WriteLine("такого элемента в массиве нет");
}




