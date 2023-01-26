// Задача 27: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int Sum(int number)
{
    if (number < 0)
    {
        number = number * (-1); 
    }
    int[] arr = new int [number];
    int sum = 0;
    int numCurrent = number;
    for (int i = 1; i < arr.Length; i++)
    {
        int numSum = numCurrent % 10; 
        sum = sum + numSum;
        numCurrent = numCurrent / 10;
    }
    return sum;
}


Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = Sum(number);


Console.WriteLine($"Результат: {result}");
