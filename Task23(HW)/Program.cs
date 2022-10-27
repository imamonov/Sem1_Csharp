// Напишите программу, которая 
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу кубов чисел от 1 до N.

// 5 -> 
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void Table(int number)
{
    int index = 1;
    while (index <= number)
    {
        Console.WriteLine($"{index,4} | {index * index,4} | {index * index * index, 4}");
        index++;
    }
}

System.Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0) Console.WriteLine("Некорректное число");

Table(number);