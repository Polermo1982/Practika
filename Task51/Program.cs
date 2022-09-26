// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

int[,] CreateMatrixRndInt (int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)             // идём по строке
    {
        for (int j = 0; j < matrix.GetLength(1); j++)         // идём по столбцу
        {
            matrix[i, j] = i + j;
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 2} ");
            else Console.Write($"{matrix[i, j], 2} ");
        }
        Console.WriteLine("|");
    }
}

int DiagonalMatrixRndInt (int[,] matrix)
{
    int diagonalSumMatrix = default;
    for (int i = 0; i < matrix.GetLength(0); i++)                // идём по строке
    {
        for (int j = 0; j < matrix.GetLength(1); j++)            // идём по столбцу
        {
            if(i == j)
            {
                diagonalSumMatrix += matrix[i, j];
            }
        }
    }
    return diagonalSumMatrix;
}
int[,] array2D = CreateMatrixRndInt(7, 7);
PrintMatrix(array2D);

int result = DiagonalMatrixRndInt(array2D);
Console.WriteLine($"Сумма по диагонали {result}");
