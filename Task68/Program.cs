// Задача 68: Напишите 
// программу вычисления функции Аккермана 
// с помощью рекурсии. 

// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackerman(int num1, int num2)
{
    if (num1 == 0)
    {
        return num2 + 1;
    }
    else if (num2 == 0)
    {
        return Ackerman(num1 - 1, 1);
    }
    else
    {
        return Ackerman(num1 - 1, Ackerman(num1, num2 - 1));
    }
}


Console.WriteLine("Введите натуральное число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N:");
int n = Convert.ToInt32(Console.ReadLine());


int ackerman = Ackerman(m, n);
Console.WriteLine(ackerman);