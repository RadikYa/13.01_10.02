// Задача 41: 
// 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// 2. сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3


int[] ArrDiget(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите ваше число №{i} = : ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int SearchDiget(int[] arr)
{
    int count = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}
string PrintArray(int[] arr)
{
    string array = ($"{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
        array = array + ($", {arr[i]}");
    }
    array += " -> ";
    return array;
}

Console.Write("Введите какое количество число вы хотите ввести: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arrDiget = ArrDiget(size);

Console.Write($"Ваши числа {PrintArray(arrDiget)}");


int searchDiget = SearchDiget(arrDiget);

Console.WriteLine($"Всего больше нуля {searchDiget} цифр");


