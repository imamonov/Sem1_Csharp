// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10 
// a = -9; b = -3 -> max = -3

Console.WriteLine("Введите число №1: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №2: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB)
{
    Console.WriteLine($"Большим числом среди чисел № 1 и № 2 является число №1: ({numA})");
    Console.WriteLine($"Меньшим числом среди чисел № 1 и № 2 является число №2: ({numB})");
}
else
{
    Console.WriteLine($"Большим числом среди чисел № 1 и № 2 является число №2: ({numB})");
    Console.WriteLine($"Меньшим числом среди чисел № 1 и № 2 является число №1: ({numA})");
}