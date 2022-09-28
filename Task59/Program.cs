// Задача 59. Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент
// массива.
// Задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// наименьший элемент - 1, на выходе получим массив:
// 9 2 3
// 4 2 4
// 2 6 7

int[,] CreateMatrix(int rows, int columns, int min, int max)
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

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j], 2} ");
            else Console.Write($"{matr[i, j], 2} ");
        }
        Console.WriteLine("");
    }
}

int[] FindMin(int[,] arr)
{
    int min = arr[0, 0];
    int indexminI = 0;
    int indexminJ = 0;
    int[] indexmin = new int[2];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (min > arr[i, j])
            {
                min = arr[i, j];
                indexminI = i;
                indexminJ = j;
                indexmin[0] = indexminI;
                indexmin[1] = indexminJ;
            } 
        }
    }
    return indexmin;
}

int[,] DeleteRowColumn(int[] index, int[,] matr)
{
    int[,] newmatrix = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i != index[0] && j != index[1])
            {
                newmatrix[i, j] = matr[i, j];
            }
        }
    }
    return newmatrix;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

int[,] matrix = CreateMatrix(4, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[] array = FindMin(matrix);
Console.Write("Индекс наименьшего значения равен: ");
PrintArray(array);
Console.WriteLine();
int[,] newMatrix = DeleteRowColumn(array, matrix);
PrintMatrix(newMatrix);
