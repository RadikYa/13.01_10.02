// Задача 15: Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


bool weekEnd(int number)
{
    return number > 5 && number < 8;
}

Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7)
{
    Console.WriteLine($"Цифра {number} является больше семи");
}
else if (number < 1)
{
    Console.WriteLine($"Цифра {number} является меньше одного");
}
else
{
    bool result = weekEnd(number);

    if (result) Console.WriteLine("да");
    else Console.WriteLine("нет");
}



