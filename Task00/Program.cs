//Напишите программу, которая
// 1. на вход принимает число и 
// 2. выдаёт его квадрат (число умноженное на само себя).

// Например: 
// 4 -> 16
// -3 -> 9 
// -7 -> 49

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

// Как можно записать строку 11 другим способом, разбив формулу на две:
// string str = Console.ReadLine();
// int num = Convert.ToInt32(str);

int square = num * num;
Console.WriteLine($"Квадрат числа {num} = {square}");
