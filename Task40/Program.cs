//  Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите первую сторону треугольника: ");
int AB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую сторону треугольника: ");
int BC = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третью сторону треугольника: ");
int CA = Convert.ToInt32(Console.ReadLine());

if ((AB + BC) > CA && (BC + CA) > AB && (CA + AB) > BC)
{
    Console.WriteLine("Такой треугольник существует.");
}
else Console.WriteLine("Такого треугольника не существует.");