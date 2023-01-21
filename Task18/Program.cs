// Задача 18: Напишите программу, которая 
// по заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


Console.Write("Введите номер плоскости: ");
string number = Console.ReadLine();

string quarter = Quarter(number);

Console.WriteLine(quarter);

string Quarter(string num)
{
    // if(xc > 0 && yc > 0) return 1;
    // if(xc < 0 && yc > 0) return 2;
    // if(xc < 0 && yc < 0) return 3;
    // if(xc > 0 && yc < 0) return 4;
    // return 0;

    // if (num == "1") return "Допустимые координаты: x > 0 и y > 0";
    // if (num == "2") return "Допустимые координаты: x < 0 и y > 0";
    // if (num == "3") return "Допустимые координаты: x < 0 и y < 0";
    // if (num == "4") return "Допустимые координаты: x > 0 и y < 0";
    // return "Неккоректный ввод!";

    switch (num)
    {
        case "1": return "Допустимые координаты: x > 0 и y > 0";
        case "2": return "Допустимые координаты: x < 0 и y > 0";
        case "3": return "Допустимые координаты: x < 0 и y < 0";
        case "4": return "Допустимые координаты: x > 0 и y < 0";
        default: return "Неккоректный ввод!";
    }
}

// Math.Pow(2, 10);
// Math.Sqrt(5);

// double d = 5.09997623455;
// double dRuynd = Math.Round(d, 2, MidpointRounding.ToZero);
// System.Console.WriteLine(dRuynd);