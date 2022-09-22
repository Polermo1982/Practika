// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int[,] CreateMatrixRndInt (int rows, int columns, int min, int max) //Метод доя заполнения двумерного массива.
{
    int[,] matrix = new int[rows, columns];

    Random rnd = new Random();                     //Нужно создать 2 метода. По строке и столбцу.             
    for (int i = 0; i < matrix.GetLength(0); i++) //Цикл for - просто задаем итерации. Сколько зададим столько и выполнит.  идём по строке.
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // идём по столбцу (1) - это как раз количество итераций!(должно соответствовать строкам и столбцам.)
        {
            matrix[i, j] = rnd.Next(min, max + 1); //Как мы идём по столбцам и строкам определяется только индексами i и j (если i и j поменяем местами то просчёт будет проходить не по строке, а вниз по столбцу).
        }
    }
    return matrix;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5} ");
            else Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("|");     //Эту строку добавляем чтобы программа вывела числа не в одну строчку, а с переводом на следующую строку.
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, -99, 99); //array2D - название переменной для вывода. Параметры вывода массива - что вывести на экран - строки, столбцы, числа в нем от -99 до 99
PrintMatrix(array2D);
