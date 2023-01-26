// Задача 25: Напишите 
// 1. цикл, который принимает на вход два числа (A и B) и 
// 2/ возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Degree(int number, int numberDegree)
{
    int degreeNow = number;
    for (int i = 1; i < numberDegree; i++)
    {
        degreeNow = degreeNow * number;
    }
    return degreeNow;
}


Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("В какую степень нужно возвести число, которое вы ввели: ");
int numberDegree = Convert.ToInt32(Console.ReadLine());


int result = Degree(number, numberDegree);

if (numberDegree < 1)
{
    Console.WriteLine($"Степень должна быть больше нуля");
}
else
{
    Console.WriteLine($"Результат: {result}");
}

