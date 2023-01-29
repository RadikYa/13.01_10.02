// Задача 36: Задайте одномерный 
// 1. массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");

}

int NotAnEvenPosition(int[] array)
{
    int sumNum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 > 0)
        {
            sumNum = sumNum + array[i];
        }
    }
    return sumNum;
}

int[] arr = CreateArrayRndInt(5, -9, 9);
PrintArray(arr);

int sumNotAnEvenPosition = NotAnEvenPosition(arr);
Console.Write($" -> {sumNotAnEvenPosition}");