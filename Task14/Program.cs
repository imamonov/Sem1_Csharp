// Напишите программу, которая 
// 1. принимает на вход число и 
// 2. проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

bool Number(int numA)
{
    int a = numA % 7;
    int b = numA % 23;
    return a == 0 && b == 0;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Number(number) ? "кратное" : "не кратно");