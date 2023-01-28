// Задача 29: Напишите программу, которая 
// 1. задаёт массив из 8 элементов и 
// 2. выводит их на экран в таком формате:

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] GenerateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[7]} -> ");
    
    // 1-ый вариант: 

    // Console.Write($"[{arr[0]}, {arr[1]}, {arr[2]}, {arr[3]}, {arr[4]}, {arr[5]}, {arr[6]}, {arr[7]}]");

   // 2-ой вариант: 

    Console.WriteLine("[{0}]", string.Join(", ", arr));

   // 3-ий вариант: 
   
    // Console.Write("[");
    // for (int i = 0; i < arr.Length - 1; i++)
    // {
    //     Console.Write($"{arr[i]}, ");
    // }
    // Console.Write($"{arr[7]}]");
}

int[] array = GenerateArray(8, 0, 99);
PrintArray(array);


// void PrintArray (int[] array) 
// {
//    // Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(i < array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}");
//     }
//     //Console.WriteLine("]");
// }

// int[] arr = CreateArrayRndInt(12, -9, 9);
// PrintArray(arr);
// System.Console.Write(" -> [");
// PrintArray(arr);
// System.Console.WriteLine("]");