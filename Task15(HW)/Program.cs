// // Напишите программу, которая
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.

// Пример:
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели");
int day_week = Convert.ToInt32(Console.ReadLine());

if (day_week < 1 || day_week > 7)
Console.WriteLine("Такого дня недели не существует");
else if (day_week == 6 || day_week == 7)
{
    Console.WriteLine("-> Да");
}
else
{
    Console.WriteLine("-> Нет");
}