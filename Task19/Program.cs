//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


Console.Clear();
void Polindrom(int number)
{
    while (number > 99999 || number <= 9999)
    {
        Console.WriteLine("Вы ввели неверное число!");
        Console.Write("Введите пятизначное число: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    int x1 = number % 10;
    int x2 = number / 10 % 10;
    int x4 = number / 1000 % 10;
    int x5 = number / 10000 % 10;
    if (x1 == x5)
    {
        if (x2 == x4)
        {
            Console.WriteLine("Число является полиндромом");
        }
        else Console.WriteLine("Число не является полиндромом");
    }
}
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Polindrom(number);