// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = (0);
while (num1 < num)
{
    if (num1 % 2 == 0)
    {
        Console.Write($"{num1}, ");
        num1 = (num1 + 1);
    }
    else if (num1 % 2 == 1)
    {
        num1 = num1 + 1;
    }

}


        
    
