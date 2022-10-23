// Напишите программу, которая 
// 1. выводит третью цифру заданного числа или 
// 2. сообщает, что третьей цифры нет. 
// * Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// Пример:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int third_digit = 0;

if (number < 0) number = -number;
if (number < 100) Console.WriteLine($"В заданном числе {number} отсутствует третья цифра");

while (number < 99 || number > 1000)
{
    number = number / 10;
}
third_digit = number % 10;
Console.WriteLine($"Третья цифра числа => {third_digit}");
