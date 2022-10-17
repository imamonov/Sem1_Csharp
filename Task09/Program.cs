// Напишите программу, которая 
// 1. выводит случайное число из отрезка [10, 99] и 
// 2. показывает наибольшую цифру числа.
// Пример:
// 78 -> 8
// 12-> 2
// 85 -> 8

// Первое решение:
int num = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона 10 -99 -> {num}");

// int firstDigit = num / 10; // 78 / 10 = 7 - целочисленное деление
// int secondDigit = num % 10; // 78 % 10 = 8 - остаток от деления

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа: {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа: {secondDigit}");

// Решение через тернарный оператор:
// int result = firstDigit > secondDigit ? firstDigit : secondDigit;
// // ? - тогда, : - иначе
// Console.WriteLine($"Наибольшая цифра числа: {result}");

// Еще один вариант решения:
// int max = Math.Max(firstDigit, secondDigit);
// Console.WriteLine($"Наибольшая цифра числа: {max}");

// Решение через функции:

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(num);
Console.WriteLine($"Наибольшая цифра числа: {maxDigit}");