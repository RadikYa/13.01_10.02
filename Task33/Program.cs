// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool NumberTrueFalse(int number, int[] array)
{
  bool isNumber = false;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] == number) isNumber = true;
  }
  return isNumber;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("] -> ");
}


int number = 4;
int[] arr = CreateArrayRndInt(5, 1, 1000);
Console.Write($"{number}; массив ");
PrintArray(arr);
bool numberTrueFalse = NumberTrueFalse(4,arr);
Console.WriteLine($"{numberTrueFalse}");



