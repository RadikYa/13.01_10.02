// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


string DecToBin(int num)
{
    string result = string.Empty;
    while (num > 0)
    {        
        result = num % 2 + result; // от порядка операции зависит результат
        num = num /2;
    }

    return result;
}


Console.Write("Введите десятичное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

string decToBin = DecToBin(number1);

Console.WriteLine(decToBin);


// int DecimalToBinary(int num)
// {
//     int res = 0;
//     int count = 1;
//     while (num > 0)
//     {
//         res += num % 2 * count;   // 45 / 2 = 1, 1 + 0*10 = 1, 1 + 100 = 101 , 
//         num /= 2;                   // 45 / 2 = 22 , 22 / 2 = 11 , 11 / 2 = 5 ,
//         count *= 10;              // 10, 100 ,  1000
//     }
//     return res;

// }

// Console.Write("Введите число в десятично системе исчисления:");
// int number = Convert.ToInt32(Console.ReadLine());

// int decimalToBinary = DecimalToBinary(number);
// Console.WriteLine($"{number} -> {decimalToBinary}");