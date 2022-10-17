// Напишите программу, которая 
// 1. выводит случайное трёхзначное число и 
// 2. удаляет вторую цифру этого числа.
// Например:
// 456 -> 46
// 782 -> 72
// 918 -> 98

// Классическое решение:
// int num = new Random().Next(99,1000);
// Console.WriteLine(num);

// int firstDigit = num / 100;
// int thirdDigit = num % 10;

// Console.WriteLine($"{firstDigit}{thirdDigit}");

// Решение через Method:

int num = new Random().Next(99,1000);
Console.WriteLine(num);

int NewNum(int num2)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    return firstDigit * 10 + thirdDigit;
}
Console.WriteLine($"Получившееся число: {NewNum(num)}");