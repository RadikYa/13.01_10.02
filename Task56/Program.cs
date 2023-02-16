// Задача 56: 
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка



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


int ArithmeticMean(int[,] matrix)
{

    int iRowWithMinSum = default;
    int sumRows = default;
    for (int i = 0; i < matrix.GetLength(1); i += 1)
    {
        int tmp = default;
        for (int j = 0; j < matrix.GetLength(1); j += 1)
        {
            tmp += matrix[i, j];
        }
        if (i == 0) sumRows = tmp;
        else
        {
            if (tmp < sumRows)
            {
                sumRows = tmp;
                iRowWithMinSum = 1;
            }
        }
    }
    return iRowWithMinSum;
}

string PrintMatrix(int[,] matrix)
{
    string str = string.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        str += "[";
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == matrix.GetLength(1) - 1) str += $" {matrix[i, j],3}  ";
            else str += $" {matrix[i, j],3} ";
        }
        str += "]\n";
    }
    return str;
}


int[,] array2D = CreateMatrixRndInt(4, 4, 0, 10);
Console.WriteLine($"Матрица \n{PrintMatrix(array2D)}");
// PrintMatrix(array2D);
int arithmeticMean = ArithmeticMean(array2D);
// PrintMatrix(arithmeticMean);
Console.WriteLine($"Результат: строка {arithmeticMean + 1} с наименьшей суммой элементов");
