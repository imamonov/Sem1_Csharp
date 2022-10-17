// Напишите программу, которая 
// 1. принимает на вход два числа и 
// 2. проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

bool CheckOnSquare(int digit1, int digit2)
{
    return digit1 * digit1 == digit2 || digit2 * digit2 == digit1;
}

Console.WriteLine("Введите число #1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число #2: ");
int numberB = Convert.ToInt32(Console.ReadLine());

bool square = CheckOnSquare(numberA, numberB);
Console.WriteLine(square ? "является квадратом" : "не является квадратом");
