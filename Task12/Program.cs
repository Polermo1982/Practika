// Напишите программу, которая будет принимать на вход 2 числа
// и выводить является ли первое число кратным второму,
// если число 1 не кратно числу 2то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 5
// 16, 4 -> кратно


Console.Clear();
Console.WriteLine("Пользователь, введи первое число! Будь так добр...:)");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пользователь, а теперь второе вводи, будь любезен...:)");
int num2 = Convert.ToInt32(Console.ReadLine());
int kratno = num1 % num2;

if (num1 > num2)
{
    if (kratno == 0)
    {
        Console.WriteLine($"{num2} кратно {num1}");
    }
    else 
    {
        Console.WriteLine($"{num2} не кратно {num1}, остаток = {kratno}");
    }
}
else 
{   Console.WriteLine("Не сочтите за труд, и введите другие числа...");
}
