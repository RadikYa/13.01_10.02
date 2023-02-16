// Задача 58: 
// Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

int[,] ProductOfMatrixes(int[,] matrix1, int [,] matrix2)
{
    int[,] matrixMulti = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

    for (int i = 0; i < matrixMulti.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMulti.GetLength(1); j++)
        {
            matrixMulti[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrixMulti[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrixMulti;
}


string PrintMatrix(int[,] matrix)
{
    string str = string.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        str += "[";
        //Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == matrix.GetLength(1) - 1) str += $" {matrix[i, j],3}  ";
            else str += $" {matrix[i, j],3} ";
        }
        str += "]\n";
    }
    return str;
}



int[,] matrix1 = CreateMatrixRndInt(2, 2, 0, 9);
Console.WriteLine($"Первая Матрица \n{PrintMatrix(matrix1)}");
Console.WriteLine();

int[,] matrix2 = CreateMatrixRndInt(2, 2, 0, 9);
Console.WriteLine($"Вторая Матрица \n{PrintMatrix(matrix2)}");
Console.WriteLine();

if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    int[,] productOfMatrixes = ProductOfMatrixes(matrix1, matrix2);
    Console.WriteLine($"Результирующая Матрица \n{PrintMatrix(productOfMatrixes)}");
    // PrintMatrix(productOfMatrixes);
}
else
{
    Console.WriteLine("Невозможно найти произведение матриц");
}


