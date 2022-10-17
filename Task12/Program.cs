// Напишите программу, которая будет 
// 1. принимать на вход два числа и 
// 2. выводить, является ли первое число кратным второму. 
// 3. Если число 1 не кратно числу 2, то
// 4. программа выводит остаток от деления.
// Например:
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA % numberB == 0)
{
    Console.WriteLine("Первое число является кратным второму");
}
else
{
    Console.WriteLine($"{numberA % numberB}");
}
