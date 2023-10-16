// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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

int SumOfRange(int m, int n)
{
    if (m == n) return n;
    return m < n ? (m + SumOfRange(m + 1, n)) : (m + SumOfRange(m - 1, n));     
}

int m = GetUserInputInt("Введите первое натуральное число");
int n = GetUserInputInt("Введите второе натуральное число");
Console.WriteLine(m == n ? $"M = {m}; N = {n} -> {n - m}" : $"M = {m}; N = {n} -> {SumOfRange(m, n)}");