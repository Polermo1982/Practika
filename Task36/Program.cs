﻿// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] CreateArrayRndInt (int size, int min, int max)
{
    int [] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
    
}
void PrintArray (int[] array)
{   
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");       
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
    
}
int OddPosition(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=1)
    {
        if(i % 2 != 0) sum += array[i];
    }
    return sum;
}

Console.WriteLine();
int[] arr = CreateArrayRndInt(10, 1, 999);
PrintArray(arr);
Console.Write(" -> ");
int sum = OddPosition(arr);
Console.WriteLine(sum);
