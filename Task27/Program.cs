// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int summ = 0;
while (number > 0)
{
    int num = number % 10;
    number = number / 10;
    summ = summ + num;
}
Console.WriteLine("Сумма всех цифр числа равна: "+summ);


