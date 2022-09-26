// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

int[,] CreateMatrixRndInt (int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // идём по строке
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // идём по столбцу
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5} ");
            else Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}

int[,] SqrtMatrixRndInt (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // идём по строке
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // идём по столбцу
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] *= matrix[i, j];
            }
        }
    }
    return matrix;
}
int[,] array2D = CreateMatrixRndInt(3, 4);
PrintMatrix(array2D);

int[,] array2D1 = SqrtMatrixRndInt(array2D);
PrintMatrix(array2D1);