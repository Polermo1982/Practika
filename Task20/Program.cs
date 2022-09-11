//Напишите программу которая принимает на вход координаты двух точек
//и находит расстояние между ними в 2д пространстве.
//a-3,6 b-2,1 = 5,09
//a-7,-5 b-1,-1 = 7,21


Console.Clear();
Console.Write("Введите координаты первой точки: ");
Console.Write("x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты второй точки: ");
Console.Write("x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double ABDistance(int xc1, int yc1, int xc2, int yc2)
{
    double d = (xc2 - xc1) * (xc2 - xc1) + (yc2 - yc1) * (yc2 - yc1);
    return Math.Round(Math.Sqrt(d), 2, MidpointRounding.ToZero);        //Строка округляет результат до 2 знака после запятой
}
Console.WriteLine(ABDistance(x1, y1, x2, y2));
