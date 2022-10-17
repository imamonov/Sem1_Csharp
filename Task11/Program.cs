// Напишите программу, которая 
// 1. выводит случайное трёхзначное число и 
// 2. удаляет вторую цифру этого числа.
// Например:
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(99,1000);
Console.WriteLine(num);

int firstDigit = num / 100;
int thirdDigit = num % 10;

Console.WriteLine($"{firstDigit}{thirdDigit}");