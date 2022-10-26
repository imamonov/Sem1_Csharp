// Напишите программу, которая 
// 1. принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
// 2. выдаёт номер четверти плоскости, в которой находится эта точка.

// Мое решение:

// Console.WriteLine("Введите координаты точки X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты точки Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x == 0 || y == 0)
// {
//     Console.WriteLine("Неверно заданные координаты точки");
// }
// else
// {
//     if (x > 0 && y > 0) Console.WriteLine("1 четверть");
//     if (x < 0 && y > 0) Console.WriteLine("2 четверть");
//     if (x < 0 && y < 0) Console.WriteLine("3 четверть");
//     if (x > 0 && y < 0) Console.WriteLine("4 четверть");
// }

// Решение преподавателя:

Console.WriteLine ("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter(int xc, int yc)
{
    if(xc > 0 && yc > 0) return 1;
    if(xc < 0 && yc > 0) return 2;
    if(xc < 0 && yc < 0) return 3;
    if(xc > 0 && yc < 0) return 4;
    return 0;
}

int quarter = Quarter(x, y);
string result = quarter > 0 
                ? $"Указанные координаты соответствуют четверти -> {quarter}" // ? - тогда
                : "Введены некорректные координаты"; // : - иначе 
Console.WriteLine(result);