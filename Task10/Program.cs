// Задача 10: Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа. 
// 3. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

int numberSecond(int number)
{
    return (number / 10) % 10;
}

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = numberSecond(number);

Console.Write($"Вторая цифра: {result}");