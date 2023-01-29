// Задача 38: Задайте 
// 1. массив вещественных чисел. 
// 2. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


// Первый вариант:


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 2);
    }
    return array;
}

void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

double MaxNum(double[] array)
{
    double maxNum = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNum)
        {
            maxNum = array[i];
        }
    }
    return maxNum;
}


double MinNum(double[] array)
{
    double minNum = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minNum)
        {
            minNum = array[i];
        }
    }
    return minNum;
}

double DifferenceBetweenMaxMin(double maxNumber, double minNumber)
{
    double difference = Math.Round(maxNumber - minNumber, 2);

    return difference;
}

double[] arr = CreateArrayRndDouble(5, 0, 9);
PrintArrayDouble(arr);

double max = MaxNum(arr);
double min = MinNum(arr);

double differenceBetweenMaxMin = DifferenceBetweenMaxMin(max, min);
Console.Write($" -> {differenceBetweenMaxMin}");


// Второй вариант:

// double[] CreateArrayRndDouble(int size, int min, int max)
// {
//     double[] array = new double[size];
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 2);
//     }
//     return array;
// }

// void PrintArrayDouble(double[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}");
//     }
//     Console.Write("]");
// }

// double DifferenceBetweenMaxMin(double[] array)
// {
//     double maxNum = array[0];
//     double minNum = array[0];
//     double difference = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > maxNum)
//         {
//             maxNum = array[i];
//         }
//         if (array[i] < minNum)
//         {
//             minNum = array[i];
//         }
//     }
//     difference = Math.Round(maxNum - minNum, 2);
//     return difference;
// }


// double[] arr = CreateArrayRndDouble(5, 0, 9);
// PrintArrayDouble(arr);

// double differenceBetweenMaxMin = DifferenceBetweenMaxMin(arr);
// Console.Write($" -> {differenceBetweenMaxMin}");