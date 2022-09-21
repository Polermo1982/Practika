// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Clear();
Console.Write("Введите нужное количество цифр: ");
int count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[count];
int i = 0;
while (i < count)
{
    Console.Write("Введите цифру: ");
    int digit = Convert.ToInt32(Console.ReadLine());
    array[i] = digit;
    i += 1;
}
int countUser = 0;
int j = 0;
while (j < array.Length)
{
    if (array[j] > 0) countUser += 1;
    j += 1;
}
Console.WriteLine($"Пользователь ввёл количество чисел больше 0 равное {countUser}");