// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
Console.WriteLine("Пользователь, введите массив чисел: ");
int[] array = new int [8];
int count = array.Length;
int Numbers = 0;
while(Numbers < count)
{
    array[Numbers] = Convert.ToInt32(Console.ReadLine());
    Numbers++;
}
for (int i=0; i<count; i++)
{
    Console.Write($"{array [i]}, ");              //Выводит на экран цифры массива с пробелом и через запятую.
}


