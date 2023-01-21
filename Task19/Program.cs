// Задача 19

// Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


bool palindrome(int number)
{
    int numberFirst = number / 10000;
    int numberSecond = (number / 1000) % 10;
    int numberFourth = (number / 10) % 10;
    int numberFifth = number % 10;
    return numberFirst == numberFifth && numberSecond == numberFourth;
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number > 99999)
{
    Console.WriteLine($"Число {number} больше пятизначного числа");
}
else if (number < 10000)
{
    Console.WriteLine($"Число {number} меньше пятизначного числа");
}
else
{
    bool result = palindrome(number);

    if (result) Console.WriteLine("да");
    else Console.WriteLine("нет");
}


