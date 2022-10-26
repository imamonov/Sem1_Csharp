// Напишите программу, которая
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу квадратов числа от 1 до N

void Table(int number)
{
    if (number > 0)
    {
        int index = 1;
        while (index <= number)
        {
            Console.WriteLine($"{index,4} | {index * index,4}");
            index++;
        }
    }
    else Console.WriteLine("Некорректное число");
}

System.Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

Table(number);