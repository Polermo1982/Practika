// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщения для пользователя.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3}");
            else Console.Write($"{matrix[i, j], 3}");
        }
        Console.WriteLine("|");
    }
}

int[,] ChangePlace(int[,] arr)
{
    int[,] arrResult = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arrResult[i, j] = arr[j, i];
        }
    }
    return arrResult;
}

bool CheckSq(int[,] array)
{
    return array.GetLength(0) == array.GetLength(1);
}

int[,] array2D = CreateMatrixRndInt(5, 5, 1, 10);
PrintArray(array2D);
Console.WriteLine();

if (CheckSq(array2D))
{
    int[,] array = ChangePlace(array2D);
    PrintArray(array);
}
else Console.WriteLine("Выполнить невозмоно!");