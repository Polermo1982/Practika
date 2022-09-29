// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Write("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
// Console.ForegroundColor=ConsoleColor.White;
// Console.ResetColor();

Console.Write($"M = {numM}; N = {numN} --> ");
void NaturalNumbers(int numberM, int numberN)
{
    if (numberN < numberM) return;
    NaturalNumbers(numberM, numberN - 1);
    Console.Write($"{numberN} ");
}

NaturalNumbers(numM, numN);