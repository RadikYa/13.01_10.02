// 0. Демонстрация решения
/* 1. на входе принимает число */
/* 2. и выдаёт его квадрат */
/* 3. вывод результата */
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");