//Напишите программу, которая выводит массив из 8 элементов
//заполненный 0 и 1 в случайном порядке.
// 0 1 2 3 4 5 6 7 8 9 10 - индексы массива начинается с 0.
//[1,0,1,1,0,0,1,0,0,1,1]


int[] arr = new int[8];      //int[] arr - имя массива(тип - int - целочисленное), new int -сам массив, [8] -количество элементов массива. Это массив где все 8 элементов это НУЛИ!!! 0. в {} задаются конкретные значения чисел в массиве, если они известны (new int[8]{1,2,4,3,5,6,8})

void FillArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(0, 2);    
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

FillArray(arr);
PrintArray(arr);
