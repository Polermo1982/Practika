//  Напишите программу, которая принимает на вход трёхзначное число 
//  и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int MaxDigit(int number)
{
    int firstDigit = (number % 100) / 10;
    return firstDigit;
}
int result = MaxDigit(number);
Console.WriteLine($"Вторая цифра числа - {result}");



