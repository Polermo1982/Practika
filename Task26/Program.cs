//Напишите программу, которая принимает на вход число
//и выдает кол-во цифр в числе
//456 -> 3
//78 -> 2
//89126 -> 5


Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int CountDigits(int num)
{
    if (num != 0)
    {
        if (num < 0) num = -num;
        int count = default;
        while (num > 0)
        {
            num = num / 10;
            count ++;
        }
        return count;
    }
    return 1;
}
int result = CountDigits(number);
Console.WriteLine(result);

