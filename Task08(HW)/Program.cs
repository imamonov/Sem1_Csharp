// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите натуральное число (N): ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 1)
    Console.WriteLine("Это недопустимое значение");
else
{
    int count = 2;
    Console.WriteLine($"Четные числа от 1 до {N}: ");
    while (count <= N)
    {
        Console.Write($"{count}, ");
        count = count + 2;
    }
}
