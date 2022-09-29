// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8




Console.Write("Введите число A: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень для возведения: ");
int degree = Convert.ToInt32(Console.ReadLine());
// Console.ForegroundColor=ConsoleColor.White;
// Console.ResetColor();

Console.Write($"A = {num}; B = {degree} -> ");
int Exponention(int numberA, int numberB)
{
    if (numberB == 0) return 1;
    return numberA *= Exponention(numberA, numberB - 1);
}

int result = Exponention(num, degree);
Console.WriteLine(result);