// Напишите программу которая принимает на вход число
// и проверяет кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int a = 7, b = 23;

if (num % a == 0 && num % b == 0)
{
    Console.WriteLine($"Число {num} кратно {a} и {b}");
}
else 
{
    Console.WriteLine($"Число {num} не кратно {a} и {b}");
}