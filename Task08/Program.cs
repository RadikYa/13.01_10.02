// Задача 8: Напишите программу, которая 
// 1. на вход принимает число (N), а 
// 2. на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    Console.Write($"{number} не является натуральным числом. ");
}

if (number < 2)
{
    Console.Write("Введите число больше 1");
}
int count = 2;

while (count <= number)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count} ");
        count = count + 2;
    }
}
