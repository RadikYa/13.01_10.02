// Задача 15: Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


int weekEnd(int number)
{
        if (number == 6 || number == 7) return number % 10;
        else if (number < 100) return number;
        number = number / 10;
    }
    return number % 10;
}

Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

