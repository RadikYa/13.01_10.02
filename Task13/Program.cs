// Задача 13: Напишите программу, которая 
// 1. выводит третью цифру заданного числа 
// 2. или сообщает, что третьей цифры нет. 
// 3. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int numberThird(int number)
{
    while (number > 999)
    {
        if (number < 1000 && number > 99) return number % 10;
        else if (number < 100) return number;
        number = number / 10;
    }
    return number % 10;
}

int number = new Random().Next(1, 1000000000);
Console.WriteLine($"Случайное число из отрезка 1 - 999 999 999 => {number}");

int result = numberThird(number);

if (number > 100)
{
    Console.WriteLine($"Третье число из числа {number} является {result}");
}
else
{
    Console.WriteLine($"Число {number} меньше трёхзначного");
}

