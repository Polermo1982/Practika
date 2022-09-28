// Задача 57. Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных
// данных.
// 1, 2, 3      1 встречается 3 раза
// 4, 6, 1      2 встречается 2 раза
// 2, 1, 6      3 встречается 1 раз
//              4 встречается 1 раз
//              6 встречатеся 2 раза

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j], 2} ");
            else Console.Write($"{matr[i, j], 2}");
        }
        Console.WriteLine(" |");
    }
}

int[] ChangeMatrixToArray(int[,] matr)
{
    int count = 0;
    int[] array = new int[matr.Length];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            array[count] = matr[i , j];
            count += 1;
        }
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

void ShowCount(int[] arr)
{
    int num = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == num) count += 1;
        else
        {
            Console.WriteLine($"{num} встречается {count}");
            num = arr[i];
            count = 1;
        }
        if (i == arr.Length - 1) Console.WriteLine($"{num} встречается {count}");
    }
}

int[,] array2D = CreateMatrix(4, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
int[] array = ChangeMatrixToArray(array2D);
Array.Sort(array);
PrintArray(array);
Console.WriteLine();
ShowCount(array);

