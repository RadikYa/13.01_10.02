// Задача 19

// Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


// bool palindrome(int number)
// {
//     int numberFirst = number / 10000;
//     int numberSecond = (number / 1000) % 10;
//     int numberFourth = (number / 10) % 10;
//     int numberFifth = number % 10;
//     return numberFirst == numberFifth && numberSecond == numberFourth;
// }

// Console.Write("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());


// if (number > 99999)
// {
//     Console.WriteLine($"Число {number} больше пятизначного числа");
// }
// else if (number < 10000)
// {
//     Console.WriteLine($"Число {number} меньше пятизначного числа");
// }
// else
// {
//     bool result = palindrome(number);

//     if (result) Console.WriteLine("да");
//     else Console.WriteLine("нет");
// }



long palindrome(long number)
{
    long numberInverted = 0;
    long numberNow = number;
    if (number < 0)
    {
        while (numberNow < 0)
        {
            long invertedNow = numberNow % 10;
            numberInverted = numberInverted * 10 + invertedNow;
            numberNow = numberNow / 10;
        }
        return (numberInverted);
    }
    else
    {
        while (numberNow > 0)
        {
            long invertedNow = numberNow % 10;
            numberInverted = numberInverted * 10 + invertedNow;
            numberNow = numberNow / 10;
        }
        return (numberInverted);
    }
}

Console.Write("Введите любое число: ");
long number = Convert.ToInt64(Console.ReadLine());

long result = palindrome(number);

Console.WriteLine($"Результат: {result}");

if (result == number)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}