// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными
//  вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

double[,] CreateArray(int rows, int columns)
{
    double[,] array = new double[rows, columns]; // Создаем 2-мерный массив
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-90, 100)/10.0; // задаем параметр переменных i, j, ДЛЯ ВЕЩЕСТВЕННЫХ ЧИСЕЛ
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} \t");  // значение "\t" это табуляция
        }
    }
    System.Console.WriteLine();
}

double[,] matrix = CreateArray(3, 4); // задаем размер массива
PrintArray(matrix);
