// Задача 52. Задайте 
// 1. двумерный массив из целых чисел. 
// 2. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; 
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}

double[] ArithmeticMean(int[,] matrix)
{
    double[] arithMean = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j += 1)
    {
        double sum = default;
        for (int i = 0; i < matrix.GetLength(0); i += 1)
        {
            sum += matrix[i, j];
        }
        double result = sum / matrix.GetLength(0);
        arithMean[j] = Math.Round(result, 1);
    }
    return arithMean;
}

void PrintArrayDouble(double[] array)
{
    Console.WriteLine(" ");
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($" {array[i]};  ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}


int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
double[] arithmeticMean = ArithmeticMean(array2D);
PrintArrayDouble(arithmeticMean);
