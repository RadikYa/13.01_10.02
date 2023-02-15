// Задача 66: 
// Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumDigits(int num1, int num2)
{
    if (num1 == num2) return num1;
    if (num1 > num2)
    {
        return num1 + SumDigits(num1 - 1, num2);
    }
    else
    {
        return num1 + SumDigits(num1 + 1, num2);
    }
}


Console.WriteLine("Введите натуральное число M:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N:");
int number2 = Convert.ToInt32(Console.ReadLine());

while (number1 <= 0 || number2 <= 0)
{
    Console.WriteLine("Вы ввели не правильное числ");

    Console.WriteLine("Введите натуральное число M:");
    number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите натуральное число N:");
    number2 = Convert.ToInt32(Console.ReadLine());
}

int result = SumDigits(number1, number2);
Console.WriteLine($"Сумма элементов в промежутке от {number1} до {number2} = {result}");
