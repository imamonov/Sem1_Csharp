// Напишите программу, которая 
// 1. по заданному номеру четверти, 
// 2. показывает диапазон возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string Quarter(int quarters)
{
if(quarters == 1) return "X > 0 и Y > 0";
if(quarters == 2) return "X < 0 и Y > 0";
if(quarters == 3) return "X < 0 и Y < 0";
if(quarters == 4) return "X > 0 и Y < 0";
return "Заданной четверти не существует";
}

string result = Quarter(quarter);

Console.WriteLine(result);


// Решение через switch case:

// string Range(int quarter)
// {
// switch (quarter)
// {
// case 1:
// return "x > 0 и y > 0";
// case 2:
// return "x < 0 и y > 0";
// case 3:
// return "x < 0 и y < 0";
// case 4:
// return "x > 0 и y < 0";
// default:
// return "Некорректные данные";
// }
// }
// Console.WriteLine("Введите номер четверти");
// int quarter = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Range(quarter));