﻿int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

// int firstDigit = number / 10; // 7
// int secondDigit = number % 10; // 8

// if (firstDigit > secondDigit) // 88
//     Console.WriteLine($"Наибольшая цифра числа => {firstDigit}");
// else
//     Console.WriteLine($"Наибольшая цифра числа => {secondDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit}");

int MaxDigit(int num)  // num = number
{
    int firstDigit = num / 10; // 7
    int secondDigit = num % 10; // 8
    if (firstDigit > secondDigit) return firstDigit;
    return secondDigit;
}
}