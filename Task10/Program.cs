// Задача 10: Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа. 
// 3. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

int numberSecond(int number)
{
    if (number < 999 || number > 100) return (number / 10) % 10;
    return number;
}

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = numberSecond(number);

if (number > 999)
{
    Console.Write($"Число {number} больше трёхначного");
}
else if (number < 100)
{
    Console.Write($"Число {number} меньше трёхначного");
}
else
{
    Console.Write($"Вторая цифра: {result}");
}