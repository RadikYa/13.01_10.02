// Задача 50. Напишите программу, которая 
// 1. на вход принимает позиции элемента в двумерном массиве, и 
// 2. возвращает значение этого элемента 
// 3. или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет


int[,] GenerateMatrixRndDouble(int rows, int columns, int min, int max)
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} | ");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}
bool Position(int[,] matrix, int rowsDigit, int colDigit)
{
    return rowsDigit < matrix.GetLength(0) && colDigit < matrix.GetLength(1);
}

int[,] array2D = GenerateMatrixRndDouble(3, 4, 1, 9);
PrintMatrix(array2D);

Console.Write("Введите позицую элемента по строке: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите позицую элемента по столбцу: ");
int columns = Convert.ToInt32(Console.ReadLine());

while (columns < 0 || rows < 0)
{
    Console.Write("Нужно ввести только положительные цифры. ");
    Console.Write("Введите позицую элемента по строке: ");
    rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите позицую элемента по столбцу: ");
    columns = Convert.ToInt32(Console.ReadLine());
}
bool position = Position(array2D, rows, columns);
Console.WriteLine(position ? $"Элемент {array2D[rows, columns] }" : "Такого элемента нет");