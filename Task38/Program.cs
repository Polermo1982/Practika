// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArray(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max) + rnd.NextDouble();
        array[i] = Math.Round(array[i], 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"|{array[i]}| ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

double Diff(double[] array)
{
    double max = array[0];
    double min = array[0];
    int a = 0;
    int b = -1;
    while (a < array.Length)
    {
        if (max < array[a]) max = array[a];
        if (min > array[a]) min = array[a];
        a += 1;
        b -= 1;
    }
    return Math.Round((max - min), 1);
}

double[] array = CreateArray(10, 1, 100);

PrintArray(array);

double result = Diff(array);
Console.WriteLine($"  >-  {result}");