// Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.

// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 || number < 100000)
{
    int firstDigit = number / 10000;
    int secondDigit = number / 1000 - number / 10000 * 10;
    int fourthDigit = number % 100 / 10;
    int fifthDigit = number % 10;

    if (firstDigit == fifthDigit && secondDigit == fourthDigit) System.Console.WriteLine("Да");
    else System.Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Введено некорректное числое");
}
