// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigits(int number)
{
    int sum = number % 10;
    if (number != 0)
    {
        sum += SumDigits(number / 10);
    }
    return sum;
}
int result = SumDigits(num);
Console.WriteLine(result);