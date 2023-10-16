// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int GetUserInputInt(string msg)
{
    int num = 0;
    bool check = CheckInput(num); 
    while (!check)
    {
        Console.Write($"{msg}: ");
        string? value = Console.ReadLine();
        num = Convert.ToInt32(value);
        check = CheckInput(num);
        if (!check) Console.WriteLine("Введите корректные данные!");
    }
    return num;
}

bool CheckInput(int n)
{
    return (n < 1 ? false : true);
}

void CountDown(int n)
{
    if (n == 0) return;
    Console.Write(n == 1? $"{n}\"" : $"{n}, ");
    CountDown(n - 1);
    
}

int n = GetUserInputInt("Введите натуральное число");
Console.Write($"N = {n} -> \"");
CountDown(n);