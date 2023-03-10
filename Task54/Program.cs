// Задача 54: 
// Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

void Replace(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int iMax = j;
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, iMax] < matrix[i, k])
                {
                    iMax = k;
                }
            }
            int tmp = matrix[i, j];
            matrix[i, j] = matrix[i, iMax];
            matrix[i, iMax] = tmp;
        }
    }
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



int[,] matrix = CreateMatrixRndInt(4, 4, 1, 99);
Console.WriteLine($"Матрица \n{PrintMatrix(matrix)}");

Replace(matrix);
Console.WriteLine($"Упорядоченная Матрица \n{PrintMatrix(matrix)}");
