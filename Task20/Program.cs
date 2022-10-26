// Напишите программу, которая
// 1. принимает на вход координаты двух точек и
// 2. находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// double d = Math.Sqrt(45);

// double s = 5.099965343;
// double res = Math.Round(s, 2, MidpointRounding.ToZero);
// System.Console.WriteLine(res);

System.Console.WriteLine("Введите координаты точки A:");
Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки B:");
Console.Write("X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1, y1, x2, y2);
System.Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));

double Distance(int xc1, int yc1, int xc2, int yc2)
{
    double square = Math.Sqrt((xc1 - xc2) * (xc1 - xc2) + (yc1 - yc2) * (yc1 - yc2));
    return square;
}