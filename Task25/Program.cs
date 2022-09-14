//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

double Stepen(int a, int b)
{
    double stepen = 1;
    if (b >= 0)
        for (int i = 0; i < b; i++)
        {
            stepen *= a;
        }
    else
        for (int i = 0; i > b; i--)
        {
            stepen /= a;
        }
    return stepen;
}
double StePen = Stepen(num1, num2);
Console.WriteLine($"{StePen}");
