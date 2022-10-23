// Напишите программу, которая
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа. 
// * Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = -number;

    if (number < 100 || number > 999)
        Console.WriteLine("Введенное число не является трехзначным");

else
{
    int second_digit = number / 10 - number / 100 * 10;
    Console.Write($"Вторая цифра числа number равна {second_digit}");
}
